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
    public partial class Main : Form
    {
        private Button btnClicked;
        public string id;
        public string name;
        public string job;
        public Main()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            btnHome_Click(sender, e);
            btnClicked = btnHome;
            btnHome.BackColor = Color.FromArgb(141, 153, 174);
            txtID.Text = id;
            txtName.Text = name;
            switch (job)
            {
                case "NV":
                    btnAccount.Hide();
                    btnTeacher.Hide();
                    break;
                case "GV":
                    btnTeacher.Hide();
                    btnAccount.Hide();
                    btnCourse.Hide();
                    break;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SetBtnClickedColor(sender);
            openChildForm(new Home());
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            SetBtnClickedColor(sender);
            openChildForm(new Teacher());

        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            SetBtnClickedColor(sender);
            openChildForm(new Course());
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            SetBtnClickedColor(sender);
            openChildForm(new Student());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            SetBtnClickedColor(sender);
            openChildForm(new User());
        }

        private void SetBtnClickedColor(object sender)
        {
            Button btn = sender as Button;
            if (btnClicked != btn)
            {
                btn.BackColor = Color.FromArgb(141, 153, 174);
                btnClicked.BackColor = Color.FromArgb(43, 45, 66);
                btnClicked.ForeColor = Color.FromArgb(237, 242, 244);
                btnClicked = btn;
            }
        }

        private void openChildForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.mainScreen.Controls.Clear();
            this.mainScreen.Controls.Add(form);
            form.Show();
        }

        private void BtnMouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Font = new Font(btn.Font.Name, btn.Font.Size + 2, btn.Font.Style);

            }
        }

        private void BtnMouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.Font = new Font(btn.Font.Name, btn.Font.Size - 2, btn.Font.Style);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
