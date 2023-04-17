﻿namespace StudentManagement
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnChg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.StudentPage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataStudent
            // 
            this.dataStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.dataStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Location = new System.Drawing.Point(29, 226);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.ReadOnly = true;
            this.dataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudent.Size = new System.Drawing.Size(689, 351);
            this.dataStudent.TabIndex = 1;
            this.dataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellClick);
            // 
            // btnAddStud
            // 
            this.btnAddStud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnAddStud.FlatAppearance.BorderSize = 0;
            this.btnAddStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStud.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStud.Location = new System.Drawing.Point(48, 170);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(89, 31);
            this.btnAddStud.TabIndex = 2;
            this.btnAddStud.Text = "Thêm";
            this.btnAddStud.UseVisualStyleBackColor = false;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(166, 170);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(89, 31);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtFind
            // 
            this.txtFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(415, 170);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(179, 28);
            this.txtFind.TabIndex = 4;
            // 
            // btnChg
            // 
            this.btnChg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnChg.FlatAppearance.BorderSize = 0;
            this.btnChg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChg.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChg.Location = new System.Drawing.Point(284, 169);
            this.btnChg.Name = "btnChg";
            this.btnChg.Size = new System.Drawing.Size(89, 31);
            this.btnChg.TabIndex = 2;
            this.btnChg.Text = "Sửa";
            this.btnChg.UseVisualStyleBackColor = false;
            this.btnChg.Click += new System.EventHandler(this.btnChg_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnChg);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.dataStudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnChg;
    }
}