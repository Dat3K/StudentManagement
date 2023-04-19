using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentManagement
{
    public partial class ManageStudent : Form
    {
        public bool isClosed = false;
        public string id;
        public DTO_Student student;
        public string type;
        private DateTime date;

        public ManageStudent()
        {
            InitializeComponent();
            btnUpdate.Hide();
            btnAdd.Hide();
            btnBoy.Checked = true;
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            if (type == "add")
            {
                btnAdd.Show();
                txtID.Text = GetId();
            }
            else if (type == "update")
            {
                btnUpdate.Show();
                student = getStudent();
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
            }
            else MessageBox.Show("Lỗi");
        }

        private DTO_Student getStudent()
        {
            return BUS_Student.GetStudentById(id);
        }

        // Hàm lấy ID mới
        private string GetId()
        {
            string maxId = BUS_Student.GetMaxId();
            int numId = int.Parse(maxId.Substring(1)) + 1;
            return "S" + numId.ToString().PadLeft(4, '0');
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

        // Hàm set trang thái form
        private void AddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }

        // Hàm nhấn nút Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValid() == false) return;

            DTO_Student student = new DTO_Student(txtID.Text, txtName.Text, date, getSex(), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);

            if (BUS_Student.AddStudent(student))
            {
                MessageBox.Show("Thêm học viên thành công");
                refreshTextBox();
                return;
            }
            MessageBox.Show("Thêm học viên thất bại");
        }

        //  Hàm check giá trị
        private bool IsValid()
        {
            bool isValid;
            CheckVariable(out date, out isValid);
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
            foreach (Control item in boxStudent.Controls)
            {
                if (item is TextBox && item.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    isValid = false;
                    return;
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
        }

        //  Nút Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid() == false) return;
            DTO_Student student = new DTO_Student(txtID.Text, txtName.Text, date, getSex(), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);
            if (BUS_Student.UpdateStudent(student))
            {
                MessageBox.Show("Sửa học viên thành công");
                return;
            }
            MessageBox.Show("Sửa học viên thất bại");
        }

    }
}
