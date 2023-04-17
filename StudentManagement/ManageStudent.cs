using BUS;
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
        public ManageStudent()
        {
            InitializeComponent();
            btnBoy.Checked = true;
        }


        private void AddStudent_Load(object sender, EventArgs e)
        {
            txtID.Text = GetId();
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
            foreach (Control item in boxStudent.Controls)
            {
                if (item is TextBox && item.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }

            DateTime date;
            if (!DateTime.TryParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date) || date > DateTime.Now)
            {
                MessageBox.Show("Nhập sai ngày sinh" + date.ToString());
                return;
            }

            DTO_Student student = new DTO_Student(txtID.Text, txtName.Text, date, getSex(), txtAddress.Text, txtPhone.Text, txtEmail.Text, txtEduLv.Text, txtMajor.Text, txtWorkExp.Text, txtLang.Text);
            int numRows = BUS_Student.AddStudent(student);
            if (numRows > 0)
            {
                MessageBox.Show("Thêm học viên thành công");
                return;
            }
            MessageBox.Show("Thêm học viên thất bại");
        }
    }
}
