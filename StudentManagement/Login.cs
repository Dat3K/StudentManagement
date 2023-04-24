using BUS;
using DTO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DTO_Staff staff = BUS_Staff.GetStaffById(txtUser.Text);
            if (txtUser.Text != "admin" && staff == null)
            {
                MessageBox.Show("Username không chính xác");
                return;
            }
            if (txtUser.Text == "admin" && txtPass.Text != "")
            {
                MessageBox.Show("Sai mật khẩu");
                return;
            }
            Main form = new Main();
            if (txtUser.Text == "admin" && txtPass.Text == "")
            {
                form.id = "ADMIN";
                form.name = "admin";
                form.job = "admin";
            }
            else
            {
                DTO_User user = BUS_User.GetUserByUserId(txtUser.Text);
                if (user == null || user.locked==true)
                {
                    MessageBox.Show("Vui lòng liên hệ admin để mở khoá tài khoản");
                    return;
                }
                if (user.Password != txtPass.Text)
                {
                    MessageBox.Show("Sai mật khẩu");
                    return;
                }
                form.id = staff.Id;
                form.name = staff.Name;
                form.job = staff.Job;
            }
            
            

            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                this.Close();
            }
            form.Show();
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignIn_Click(sender, e);
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '●') { 
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '●';
            }
        }
    }
}
