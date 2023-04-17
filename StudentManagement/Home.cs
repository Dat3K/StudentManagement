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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void btn_Hover(object sender, EventArgs e)
        {
            this.btnHome.MouseHover += new EventHandler(button_MouseHover);
            this.btnCourse.MouseHover += new EventHandler(button_MouseHover);
            this.btnTeacher.MouseHover += new EventHandler(button_MouseHover);
            this.btnStudent.MouseHover += new EventHandler(button_MouseHover);
            
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            openChidForm(new Student());
        }

        private void openChidForm(Form form)
        {
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.mainScreen.Controls.Clear();
            this.mainScreen.Controls.Add(form);
            form.Show();
        }
    }
}
