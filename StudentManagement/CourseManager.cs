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

namespace StudentManagement
{
    public partial class CourseManager : Form
    {
        public bool isClosed = false;
        public string type;
        public string id;
        public CourseManager()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach (Control item in boxData.Controls)
            {
                if (item is TextBox && item.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
            }

            if (BUS_Staff.GetStaffById(txtID.Text) == null)
            {
                MessageBox.Show("Sai mã GV");
                return;
            }

            bool SDate = DateTime.TryParseExact(txtSDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate);
            bool EDate = DateTime.TryParseExact(txtEDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate);
            if (SDate && EDate && endDate > startDate && endDate < DateTime.Now)
            {
                DTO_Course course = new DTO_Course(
                        txtID.Text,
                        txtName.Text,
                        txtDescription.Text,
                        txtSID.Text,
                        txtSDate.Text,
                        txtEDate.Text
                        );
                if (type == "update")
                {
                    if (BUS_Course.UpdateCourse(course))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        return;
                    }
                    MessageBox.Show("Cập nhật không thành công");
                }
                if (BUS_Course.AddCourse(course))
                {
                    MessageBox.Show("Thêm thành công");
                    refreshTextBox();
                    return;
                }
                MessageBox.Show("Thêm không thành công");
            }
            else
            {
                MessageBox.Show("Ngày không hợp lệ");
                return;
            }
        }

        private void refreshTextBox()
        {
            foreach (Control item in boxData.Controls)
            {
                if (item is TextBox && item.Name != txtID.Name)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox) item.Text = "";
            }
            txtID.Text = GetMaxID();
        }


        private string GetMaxID()
        {
            string maxId = BUS_Course.GetMaxId();
            int numId = int.Parse(maxId.Substring(1)) + 1;
            return "C" + numId.ToString().PadLeft(4, '0');
        }

        private void CourseManager_Load(object sender, EventArgs e)
        {
            if (type == "update")
            {
                DTO_Course course = BUS_Course.GetCourseById(id);
                txtID.Text = course.Id;
                txtName.Text = course.Name;
                txtDescription.Text = course.Description;
                txtSID.Text = course.Teacher_id;
                txtSDate.Text = course.Start_date;
                txtEDate.Text = course.End_date;
                txtID.ReadOnly = false;
                return;
            }
            txtID.Text = GetMaxID();
        }

        private void CourseManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }
    }

}
