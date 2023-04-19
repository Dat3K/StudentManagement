﻿using BUS;
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
    public partial class Student : Form
    {
        private string idStudent;
        public Student()
        {
            InitializeComponent();
            btnDel.Enabled = false;
            btnChg.Enabled = false;
        }

        private void Student_Load(object sender, EventArgs e)
        {
            dataStudent.DataSource = BUS_Student.GetData();
        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.type = "add";
            manageStudent.ShowDialog();
            if (manageStudent.isClosed)
            {
                Student_Load(sender, e);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            BUS_Student.DelStudent(idStudent);
            MessageBox.Show("Xoá thành công");
            Student_Load(sender, e);
        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataStudent.RowCount-1)
            {
                btnDel.Enabled = true;
                btnChg.Enabled = true;
                DataGridViewRow row = dataStudent.Rows[e.RowIndex];
                idStudent = row.Cells[0].Value.ToString();
            }
            else
            {
                btnDel.Enabled = false;
                btnChg.Enabled = false;
            }
        }

        private void btnChg_Click(object sender, EventArgs e)
        {
            ManageStudent manageStudent = new ManageStudent();
            manageStudent.type = "update";
            manageStudent.id = idStudent;
            manageStudent.ShowDialog();
            if (manageStudent.isClosed)
            {
                Student_Load(sender, e);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            idStudent = txtFind.Text;
            dataStudent.DataSource = BUS_Student.GetAStudentData(idStudent);
        }

        private void txtFind_Leave(object sender, EventArgs e)
        {
            dataStudent.DataSource = BUS_Student.GetData();

        }

        private void txtFind_Validated(object sender, EventArgs e)
        {
            dataStudent.DataSource = BUS_Student.GetData();

        }
    }
}
