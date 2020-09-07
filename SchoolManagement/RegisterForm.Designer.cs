namespace SchoolManagement
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studentRadBtn = new System.Windows.Forms.RadioButton();
            this.teacherRadBtn = new System.Windows.Forms.RadioButton();
            this.degreeCmbBox = new System.Windows.Forms.ComboBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.degreeLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(207, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studentRadBtn);
            this.groupBox1.Controls.Add(this.teacherRadBtn);
            this.groupBox1.Location = new System.Drawing.Point(319, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration type";
            // 
            // studentRadBtn
            // 
            this.studentRadBtn.AutoSize = true;
            this.studentRadBtn.Location = new System.Drawing.Point(34, 80);
            this.studentRadBtn.Name = "studentRadBtn";
            this.studentRadBtn.Size = new System.Drawing.Size(62, 17);
            this.studentRadBtn.TabIndex = 1;
            this.studentRadBtn.TabStop = true;
            this.studentRadBtn.Text = "Student";
            this.studentRadBtn.UseVisualStyleBackColor = true;
            this.studentRadBtn.CheckedChanged += new System.EventHandler(this.studentRadBtn_CheckedChanged);
            // 
            // teacherRadBtn
            // 
            this.teacherRadBtn.AutoSize = true;
            this.teacherRadBtn.Location = new System.Drawing.Point(34, 40);
            this.teacherRadBtn.Name = "teacherRadBtn";
            this.teacherRadBtn.Size = new System.Drawing.Size(65, 17);
            this.teacherRadBtn.TabIndex = 0;
            this.teacherRadBtn.TabStop = true;
            this.teacherRadBtn.Text = "Teacher";
            this.teacherRadBtn.UseVisualStyleBackColor = true;
            this.teacherRadBtn.CheckedChanged += new System.EventHandler(this.teacherRadBtn_CheckedChanged);
            // 
            // degreeCmbBox
            // 
            this.degreeCmbBox.FormattingEnabled = true;
            this.degreeCmbBox.Location = new System.Drawing.Point(102, 279);
            this.degreeCmbBox.Name = "degreeCmbBox";
            this.degreeCmbBox.Size = new System.Drawing.Size(85, 21);
            this.degreeCmbBox.TabIndex = 7;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(319, 307);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(155, 34);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(319, 366);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(155, 33);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.phoneBox);
            this.groupBox2.Controls.Add(this.addressBox);
            this.groupBox2.Controls.Add(this.emailBox);
            this.groupBox2.Controls.Add(this.nameBox);
            this.groupBox2.Controls.Add(this.passwordBox);
            this.groupBox2.Controls.Add(this.idBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.degreeLbl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.degreeCmbBox);
            this.groupBox2.Location = new System.Drawing.Point(46, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 326);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill your info";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(88, 234);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 21;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(87, 195);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(100, 20);
            this.addressBox.TabIndex = 20;
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(87, 153);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 19;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(87, 111);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 18;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(87, 68);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 17;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(87, 27);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Password";
            // 
            // degreeLbl
            // 
            this.degreeLbl.AutoSize = true;
            this.degreeLbl.Location = new System.Drawing.Point(6, 279);
            this.degreeLbl.Name = "degreeLbl";
            this.degreeLbl.Size = new System.Drawing.Size(90, 13);
            this.degreeLbl.TabIndex = 13;
            this.degreeLbl.Text = "Academic degree";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(145, 442);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(40, 13);
            this.errorLbl.TabIndex = 11;
            this.errorLbl.Text = "           ";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 476);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "School Management System - Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton studentRadBtn;
        private System.Windows.Forms.RadioButton teacherRadBtn;
        private System.Windows.Forms.ComboBox degreeCmbBox;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label degreeLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox idBox;
    }
}