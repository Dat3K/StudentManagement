namespace StudentManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpPass = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainScreen = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnCourse);
            this.panel1.Controls.Add(this.btnStudent);
            this.panel1.Controls.Add(this.btnTeacher);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 600);
            this.panel1.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnAccount.Image = global::StudentManagement.Properties.Resources.Vector;
            this.btnAccount.Location = new System.Drawing.Point(0, 520);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(250, 80);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "   Tài khoản";
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            this.btnAccount.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnCourse
            // 
            this.btnCourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourse.FlatAppearance.BorderSize = 0;
            this.btnCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourse.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnCourse.Image = global::StudentManagement.Properties.Resources.material_symbols_menu_book_outline_rounded;
            this.btnCourse.Location = new System.Drawing.Point(0, 440);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(250, 80);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "   Khoá học";
            this.btnCourse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            this.btnCourse.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnCourse.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnStudent
            // 
            this.btnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudent.FlatAppearance.BorderSize = 0;
            this.btnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudent.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnStudent.Image = global::StudentManagement.Properties.Resources.ph_student_bold;
            this.btnStudent.Location = new System.Drawing.Point(0, 360);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(250, 80);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "  Học viên";
            this.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            this.btnStudent.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnStudent.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnTeacher.Image = global::StudentManagement.Properties.Resources.mdi_teacher;
            this.btnTeacher.Location = new System.Drawing.Point(0, 280);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(250, 80);
            this.btnTeacher.TabIndex = 2;
            this.btnTeacher.Text = "  Giáo viên";
            this.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            this.btnTeacher.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnTeacher.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.btnHome.Image = global::StudentManagement.Properties.Resources.Home1;
            this.btnHome.Location = new System.Drawing.Point(0, 200);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(250, 80);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = " Trang chính";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.BtnMouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.BtnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpPass);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 200);
            this.panel2.TabIndex = 0;
            // 
            // btnUpPass
            // 
            this.btnUpPass.BackgroundImage = global::StudentManagement.Properties.Resources.carbon_password;
            this.btnUpPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpPass.FlatAppearance.BorderSize = 0;
            this.btnUpPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpPass.Location = new System.Drawing.Point(208, 0);
            this.btnUpPass.Name = "btnUpPass";
            this.btnUpPass.Size = new System.Drawing.Size(42, 45);
            this.btnUpPass.TabIndex = 3;
            this.btnUpPass.UseVisualStyleBackColor = true;
            this.btnUpPass.Visible = false;
            this.btnUpPass.Click += new System.EventHandler(this.btnUpPass_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = global::StudentManagement.Properties.Resources.solar_logout_2_bold;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(42, 45);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtName.Location = new System.Drawing.Point(12, 151);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 33);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.txtID.Location = new System.Drawing.Point(52, 115);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 36);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "ID";
            this.txtID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainScreen
            // 
            this.mainScreen.Controls.Add(this.pictureBox2);
            this.mainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScreen.Location = new System.Drawing.Point(250, 0);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.Size = new System.Drawing.Size(750, 600);
            this.mainScreen.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(750, 600);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainScreen);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1016, 639);
            this.MinimumSize = new System.Drawing.Size(1016, 639);
            this.Name = "Main";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainScreen;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnUpPass;
    }
}