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
    public partial class User : Form
    {
        private string idUser;

        public User()
        {
            InitializeComponent();
            btnDel.Enabled = false;
            btnChg.Enabled = false;
        }

        private void User_Load(object sender, EventArgs e)
        {
            dataUser.DataSource = BUS_User.GetData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Register manageUser = new Register();
            manageUser.ShowDialog();
            if (manageUser.isClosed)
            {
                User_Load(sender, e);
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            BUS_User.DelUser(idUser);
            MessageBox.Show("Xoá thành công");
            User_Load(sender, e);
        }
        private void dataUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataUser.RowCount - 1)
            {
                btnDel.Enabled = true;
                btnChg.Enabled = true;
                DataGridViewRow row = dataUser.Rows[e.RowIndex];
                idUser = row.Cells[0].Value.ToString();
            }
            else
            {
                btnDel.Enabled = false;
                btnChg.Enabled = false;
            }
        }
        private void btnChg_Click(object sender, EventArgs e)
        {
            Register manageUser = new Register
            {
                type = "update",
                id = idUser
            };
            manageUser.ShowDialog();
            if (manageUser.isClosed)
            {
                User_Load(sender, e);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            idUser = txtFind.Text;
            dataUser.DataSource = BUS_User.GetAUserData(idUser);
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            dataUser.DataSource = BUS_User.GetData();

        }

        private void TxtFind_Validated(object sender, EventArgs e)
        {
            dataUser.DataSource = BUS_User.GetData();
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
