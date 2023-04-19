using BUS;
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
        private int numStudent;
        public Home()
        {
            InitializeComponent();
            numStudent = BUS_Student.GetStudentCount();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            txtNumStudent.Text = numStudent.ToString();
        }
    }
}
