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
    public partial class Teacher : Form
    {
        private string idStaff;
        public Teacher()
        {
            InitializeComponent();
            btnDel.Enabled = false;
            btnChg.Enabled = false;
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            dataStaff.DataSource = BUS_Staff.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Manager manageStaff = new Manager
            {
                type = "add_staff"
            };
            manageStaff.ShowDialog();
            if (manageStaff.isClosed)
            {
                Teacher_Load(sender, e);
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            BUS_Staff.DelStaff(idStaff);
            MessageBox.Show("Xoá thành công");
            Teacher_Load(sender, e);
        }
        private void dataStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataStaff.RowCount - 1)
            {
                btnDel.Enabled = true;
                btnChg.Enabled = true;
                DataGridViewRow row = dataStaff.Rows[e.RowIndex];
                idStaff = row.Cells[0].Value.ToString();
            }
            else
            {
                btnDel.Enabled = false;
                btnChg.Enabled = false;
            }
        }
        private void btnChg_Click(object sender, EventArgs e)
        {
            Manager manageStaff = new Manager
            {
                type = "update_staff",
                id = idStaff
            };
            manageStaff.ShowDialog();
            if (manageStaff.isClosed)
            {
                Teacher_Load(sender, e);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            idStaff = txtFind.Text;
            dataStaff.DataSource = BUS_Staff.GetAStaffData(idStaff);
        }

        private void TxtFind_Leave(object sender, EventArgs e)
        {
            dataStaff.DataSource = BUS_Staff.GetData();

        }

        private void TxtFind_Validated(object sender, EventArgs e)
        {
            dataStaff.DataSource = BUS_Staff.GetData();
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
