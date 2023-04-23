using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Course : Form
    {
        private string idCourse;

        public Course()
        {
            InitializeComponent();
            btnDel.Enabled = false;
            btnChg.Enabled = false;
        }

        private void Course_Load(object sender, EventArgs e)
        {
            dataCourse.DataSource = BUS_Course.GetData();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CourseManager manageCourse = new CourseManager();
            manageCourse.ShowDialog();
            if (manageCourse.isClosed)
            {
                Course_Load(sender, e);
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            BUS_Course.DelCourse(idCourse);
            MessageBox.Show("Xoá thành công");
            Course_Load(sender, e);
        }
        private void dataCourse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataCourse.RowCount - 1)
            {
                btnDel.Enabled = true;
                btnChg.Enabled = true;
                DataGridViewRow row = dataCourse.Rows[e.RowIndex];
                idCourse = row.Cells[0].Value.ToString();
            }
            else
            {
                btnDel.Enabled = false;
                btnChg.Enabled = false;
            }
        }
        private void btnChg_Click(object sender, EventArgs e)
        {
            CourseManager manageCourse = new CourseManager
            {
                type = "update",
                id = idCourse
            };
            manageCourse.ShowDialog();
            if (manageCourse.isClosed)
            {
                Course_Load(sender, e);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            idCourse = txtFind.Text;
            dataCourse.DataSource = BUS_Course.GetACourseData(idCourse);
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            dataCourse.DataSource = BUS_Course.GetData();

        }

        private void TxtFind_Validated(object sender, EventArgs e)
        {
            dataCourse.DataSource = BUS_Course.GetData();
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnFind_Click(sender, e);
            }
        }
    }
}
