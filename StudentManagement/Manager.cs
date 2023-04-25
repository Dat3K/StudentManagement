using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentManagement
{
    public partial class Manager : Form
    {
        public bool isClosed = false;
        public string id;
        public string type;
        private DateTime date;

        public Manager()
        {
            InitializeComponent();
            btnBoy.Checked = true;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case "add_student":
                    txtJob.Hide();
                    labelJob.Hide();
                    txtID.Text = GetMaxId();
                    break;

                case "update_student":
                    txtJob.Hide();
                    labelJob.Hide();
                    DTO_Student student = GetStudent();
                    txtID.Text = student.Id;
                    txtName.Text = student.FullName;
                    txtDate.Text = student.DateOfBirth.ToString();
                    if (student.Gender == "Nam")
                    {
                        btnBoy.Checked = true;
                        btnGirl.Checked = false;

                    }
                    else
                    {
                        btnBoy.Checked = false;
                        btnGirl.Checked = true;
                    }
                    txtAddress.Text = student.Address;
                    txtEmail.Text = student.Email;
                    txtPhone.Text = student.PhoneNumber;
                    txtEduLv.Text = student.EducationLevel;
                    txtMajor.Text = student.Major;
                    txtWorkExp.Text = student.WorkExperience;
                    txtLang.Text = student.Language;
                    break;

                case "add_staff":
                    txtID.Text = GetMaxId();
                    break;

                case "update_staff":
                    DTO_Staff staff = GetStaff();
                    txtID.Text = staff.Id;
                    txtName.Text = staff.Name;
                    txtDate.Text = staff.DOB.ToString();
                    if (staff.Gender == "Nam")
                    {
                        btnBoy.Checked = true;
                        btnGirl.Checked = false;

                    }
                    else
                    {
                        btnBoy.Checked = false;
                        btnGirl.Checked = true;
                    }
                    txtJob.Text = staff.Job;
                    txtAddress.Text = staff.Address;
                    txtEmail.Text = staff.Email;
                    txtPhone.Text = staff.Phone;
                    txtEduLv.Text = staff.Qualification;
                    txtMajor.Text = staff.Major;
                    txtWorkExp.Text = staff.Experience;
                    txtLang.Text = staff.Language;
                    break;

                case "print_student":
                    btnUpdate.Text = "In";
                    txtJob.Hide();
                    labelJob.Hide();
                    DTO_Student studentP = GetStudent();
                    txtID.Text = studentP.Id;
                    txtName.Text = studentP.FullName;
                    txtDate.Text = studentP.DateOfBirth.ToString();
                    if (studentP.Gender == "Nam")
                    {
                        btnBoy.Checked = true;
                        btnGirl.Checked = false;

                    }
                    else
                    {
                        btnBoy.Checked = false;
                        btnGirl.Checked = true;
                    }
                    txtAddress.Text = studentP.Address;
                    txtEmail.Text = studentP.Email;
                    txtPhone.Text = studentP.PhoneNumber;
                    txtEduLv.Text = studentP.EducationLevel;
                    txtMajor.Text = studentP.Major;
                    txtWorkExp.Text = studentP.WorkExperience;
                    txtLang.Text = studentP.Language;
                    break;

                default:
                    MessageBox.Show("Lỗi");
                    break;
            }
        }

        // Hàm lấy học viên bằng id
        private DTO_Student GetStudent()
        {
            return BUS_Student.GetStudentById(id);
        }

        private DTO_Staff GetStaff()
        {
            return BUS_Staff.GetStaffById(id);
        }

        // Hàm lấy ID mới
        private string GetMaxId()
        {
            if (type == "add_student")
            {
                string maxId = BUS_Student.GetMaxId();
                int numId = int.Parse(maxId.Substring(1)) + 1;
                return "S" + numId.ToString().PadLeft(4, '0');
            }
            else
            {
                string maxId = BUS_Staff.GetMaxId();
                int numId = int.Parse(maxId.Substring(2)) + 1;
                return "ST" + numId.ToString().PadLeft(4, '0');
            }
        }

        // Hàm lấy giới tính
        private string getSex()
        {
            if (btnBoy.Checked)
            {
                return btnBoy.Text;
            }
            return btnGirl.Text;
        }

        // Hàm set trang thái forma
        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }

        //  Hàm check giá trị
        private bool IsValid()
        {
            CheckVariable(out date, out bool isValid);
            return isValid;
        }
        private void CheckVariable(out DateTime date, out bool isValid)
        {
            if (!DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) || date > DateTime.Now)
            {
                MessageBox.Show("Nhập sai ngày sinh" + date.ToString());
                isValid = false;
                return;
            }

            string[] parts = type.Split('_');
            if (parts[1] == "student")
            {
                foreach (Control item in boxStudent.Controls)
                {
                    if (item is TextBox && item.Text == "" && item.Name != txtJob.Name)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        isValid = false;
                        return;
                    }
                }
            }
            else
            {
                foreach (Control item in boxStudent.Controls)
                {
                    if (item is TextBox && item.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                        isValid = false;
                        return;
                    }
                }
            }
            isValid = true;

        }

        // Làm mới textbox
        private void refreshTextBox()
        {
            foreach (Control item in boxStudent.Controls)
            {
                if (item is TextBox && item.Name != txtID.Name)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox) item.Text = "";
            }
            txtID.Text = GetMaxId();
        }

        //  Nút Lưu
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid() == false) return;

            switch (type)
            {
                case "add_student":

                    DTO_Student student = new DTO_Student(txtID.Text, txtName.Text, date, getSex(), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);
                    if (!BUS_Student.AddStudent(student))
                    {
                        MessageBox.Show("Thêm học viên thất bại");
                        break;
                    }
                    MessageBox.Show("Thêm học viên thành công");
                    refreshTextBox();
                    break;

                case "update_student":
                    DTO_Student studentUp = new DTO_Student(txtID.Text, txtName.Text, date, getSex(), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);
                    if (!BUS_Student.UpdateStudent(studentUp))
                    {
                        MessageBox.Show("Sửa học viên thất bại");
                        break;
                    }
                    MessageBox.Show("Sửa học viên thành công");
                    break;

                case "add_staff":
                    DTO_Staff staff = new DTO_Staff(txtID.Text, txtName.Text, date, getSex(), txtJob.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);
                    if (!BUS_Staff.AddStaff(staff))
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                        break;
                    }
                    MessageBox.Show("Thêm nhân viên thành công");
                    refreshTextBox();
                    break;

                case "update_staff":
                    DTO_Staff staffUp = new DTO_Staff(txtID.Text, txtName.Text, date, getSex(), txtJob.Text, txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);
                    if (!BUS_Staff.UpdateStaff(staffUp))
                    {
                        MessageBox.Show("Sửa nhân viên thất bại");
                        break;
                    }
                    MessageBox.Show("Sửa nhân viên thành công");
                    break;

                case "print_student":
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                    break;

                default:
                    MessageBox.Show("Lỗi");
                    break;
            }
        }
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Lấy thông tin học viên từ các control trên form
            int id = int.Parse(txtID.Text);
            string name = txtName.Text;
            string dob = txtDate.Text;
            string address = txtAddress.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string edLvl = txtEduLv.Text;
            string major = txtMajor.Text;
            string wEx = txtWorkExp.Text;
            string language = txtLang.Text;

            // Vẽ thông tin học viên lên trang in
            int x = 100;
            int y = 100;
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            e.Graphics.DrawString("Id: " + id.ToString(), font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Họ Tên: " + name, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Ngày sinh: " + dob, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Địa chỉ: " + address, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Điện thoại: " + phone, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Email: " + email, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Trình độ học vấn: " + edLvl, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Ngành học: " + major, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Kinh nghiệm làm việc: " + wEx, font, brush, new Point(x, y));
            y += 20;
            e.Graphics.DrawString("Ngôn ngữ: " + language, font, brush, new Point(x, y));

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
