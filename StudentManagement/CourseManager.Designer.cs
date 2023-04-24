namespace StudentManagement
{
    partial class CourseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseManager));
            this.label11 = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.boxData = new System.Windows.Forms.GroupBox();
            this.txtEDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDate = new System.Windows.Forms.MaskedTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(336, 43);
            this.label11.TabIndex = 29;
            this.label11.Text = "Thông tin khoá học:";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJob.Location = new System.Drawing.Point(35, 312);
            this.labelJob.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(137, 24);
            this.labelJob.TabIndex = 27;
            this.labelJob.Text = "Ngày bắt đầu:";
            // 
            // txtSID
            // 
            this.txtSID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSID.Location = new System.Drawing.Point(184, 243);
            this.txtSID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(213, 32);
            this.txtSID.TabIndex = 26;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(426, 33);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // boxData
            // 
            this.boxData.Controls.Add(this.labelJob);
            this.boxData.Controls.Add(this.label1);
            this.boxData.Controls.Add(this.label9);
            this.boxData.Controls.Add(this.label2);
            this.boxData.Controls.Add(this.label3);
            this.boxData.Controls.Add(this.label5);
            this.boxData.Controls.Add(this.txtEDate);
            this.boxData.Controls.Add(this.txtSDate);
            this.boxData.Controls.Add(this.txtSID);
            this.boxData.Controls.Add(this.txtDescription);
            this.boxData.Controls.Add(this.txtID);
            this.boxData.Controls.Add(this.txtName);
            this.boxData.Location = new System.Drawing.Point(23, 61);
            this.boxData.Name = "boxData";
            this.boxData.Size = new System.Drawing.Size(484, 457);
            this.boxData.TabIndex = 27;
            this.boxData.TabStop = false;
            // 
            // txtEDate
            // 
            this.txtEDate.Location = new System.Drawing.Point(184, 367);
            this.txtEDate.Mask = "00/00/0000";
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.Size = new System.Drawing.Size(213, 32);
            this.txtEDate.TabIndex = 28;
            this.txtEDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // txtSDate
            // 
            this.txtSDate.Location = new System.Drawing.Point(184, 304);
            this.txtSDate.Mask = "00/00/0000";
            this.txtSDate.Name = "txtSDate";
            this.txtSDate.Size = new System.Drawing.Size(213, 32);
            this.txtSDate.TabIndex = 23;
            this.txtSDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(184, 154);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(213, 61);
            this.txtDescription.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Mô tả:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(184, 27);
            this.txtID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(213, 32);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên khoá học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã GV:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 93);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(213, 32);
            this.txtName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày kết thúc:";
            // 
            // CourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(535, 540);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.boxData);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CourseManager";
            this.Text = "Course Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseManager_FormClosed);
            this.Load += new System.EventHandler(this.CourseManager_Load);
            this.boxData.ResumeLayout(false);
            this.boxData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox boxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtSDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtEDate;
    }
}