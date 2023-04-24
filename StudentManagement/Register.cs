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
    public partial class Register : Form
    {
        public bool isClosed = false;
        public string id;
        public string type;
        DTO_User user;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            txtID.Text=GetNewId();
            if (type == "update")
            {
                user = BUS_User.GetUserById(id);
                txtID.Text = user.Id;
                txtUser.Text = user.UserId;
                txtPass.Text = user.Password;
                txtUser.ReadOnly = true;
                btnRegister.Text = "Update";
            }
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (BUS_Staff.GetStaffById(txtUser.Text) == null)
            {
                MessageBox.Show("User phải là mã nhân viên đã có");
                return;
            }
            if(txtPass.Text!=txtRePass.Text)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }

            if (type == "update")
            {
                DTO_User user1 = new DTO_User(txtID.Text, txtUser.Text, txtPass.Text, false);
                BUS_User.UpdateUser(user1);
                MessageBox.Show("Cập nhật thành công");
                this.Close();
                return;
            }
            DTO_User user = new DTO_User(GetNewId(), txtUser.Text, txtPass.Text, false);
            BUS_User.AddUser(user);

            MessageBox.Show("Tạo thành công");
            this.Close();
        }

        private string GetNewId()
        {
            string maxId = BUS_User.GetMaxId();
            int numId = int.Parse(maxId.Substring(1)) + 1;
            return "U" + numId.ToString().PadLeft(4, '0');
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister_Click(sender, e);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister_Click(sender, e);
            }
        }

        private void txtRePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegister_Click(sender, e);
            }
        }
    }
}
