namespace SchoolManagement
{
    partial class AdminForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dropStudentLbl = new System.Windows.Forms.Label();
            this.dropStudentBtn = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropTeacherLbl = new System.Windows.Forms.Label();
            this.dropTeacherBtn = new System.Windows.Forms.Button();
            this.teacherList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dropCourseLbl = new System.Windows.Forms.Label();
            this.dropCourseBtn = new System.Windows.Forms.Button();
            this.courseList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addCourseLbl = new System.Windows.Forms.Label();
            this.topicBox = new System.Windows.Forms.TextBox();
            this.creditsBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.teacherCmbBox = new System.Windows.Forms.ComboBox();
            this.addCourseBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dropStudentLbl);
            this.groupBox3.Controls.Add(this.dropStudentBtn);
            this.groupBox3.Controls.Add(this.studentList);
            this.groupBox3.Location = new System.Drawing.Point(12, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 318);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Students registered and their GPA";
            // 
            // dropStudentLbl
            // 
            this.dropStudentLbl.AutoSize = true;
            this.dropStudentLbl.Location = new System.Drawing.Point(29, 295);
            this.dropStudentLbl.Name = "dropStudentLbl";
            this.dropStudentLbl.Size = new System.Drawing.Size(25, 13);
            this.dropStudentLbl.TabIndex = 2;
            this.dropStudentLbl.Text = "      ";
            // 
            // dropStudentBtn
            // 
            this.dropStudentBtn.Location = new System.Drawing.Point(32, 247);
            this.dropStudentBtn.Name = "dropStudentBtn";
            this.dropStudentBtn.Size = new System.Drawing.Size(109, 28);
            this.dropStudentBtn.TabIndex = 1;
            this.dropStudentBtn.Text = "Drop student";
            this.dropStudentBtn.UseVisualStyleBackColor = true;
            this.dropStudentBtn.Click += new System.EventHandler(this.dropStudentBtn_Click);
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(18, 29);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(133, 212);
            this.studentList.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dropTeacherLbl);
            this.groupBox1.Controls.Add(this.dropTeacherBtn);
            this.groupBox1.Controls.Add(this.teacherList);
            this.groupBox1.Location = new System.Drawing.Point(198, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 318);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teachers registered";
            // 
            // dropTeacherLbl
            // 
            this.dropTeacherLbl.AutoSize = true;
            this.dropTeacherLbl.Location = new System.Drawing.Point(27, 295);
            this.dropTeacherLbl.Name = "dropTeacherLbl";
            this.dropTeacherLbl.Size = new System.Drawing.Size(25, 13);
            this.dropTeacherLbl.TabIndex = 3;
            this.dropTeacherLbl.Text = "      ";
            // 
            // dropTeacherBtn
            // 
            this.dropTeacherBtn.Location = new System.Drawing.Point(30, 247);
            this.dropTeacherBtn.Name = "dropTeacherBtn";
            this.dropTeacherBtn.Size = new System.Drawing.Size(109, 28);
            this.dropTeacherBtn.TabIndex = 1;
            this.dropTeacherBtn.Text = "Drop teacher";
            this.dropTeacherBtn.UseVisualStyleBackColor = true;
            this.dropTeacherBtn.Click += new System.EventHandler(this.dropTeacherBtn_Click);
            // 
            // teacherList
            // 
            this.teacherList.FormattingEnabled = true;
            this.teacherList.Location = new System.Drawing.Point(18, 29);
            this.teacherList.Name = "teacherList";
            this.teacherList.Size = new System.Drawing.Size(133, 212);
            this.teacherList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dropCourseLbl);
            this.groupBox2.Controls.Add(this.dropCourseBtn);
            this.groupBox2.Controls.Add(this.courseList);
            this.groupBox2.Location = new System.Drawing.Point(384, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 318);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course list";
            // 
            // dropCourseLbl
            // 
            this.dropCourseLbl.AutoSize = true;
            this.dropCourseLbl.Location = new System.Drawing.Point(27, 295);
            this.dropCourseLbl.Name = "dropCourseLbl";
            this.dropCourseLbl.Size = new System.Drawing.Size(22, 13);
            this.dropCourseLbl.TabIndex = 4;
            this.dropCourseLbl.Text = "     ";
            // 
            // dropCourseBtn
            // 
            this.dropCourseBtn.Location = new System.Drawing.Point(30, 247);
            this.dropCourseBtn.Name = "dropCourseBtn";
            this.dropCourseBtn.Size = new System.Drawing.Size(109, 28);
            this.dropCourseBtn.TabIndex = 1;
            this.dropCourseBtn.Text = "Drop course";
            this.dropCourseBtn.UseVisualStyleBackColor = true;
            this.dropCourseBtn.Click += new System.EventHandler(this.dropCourseBtn_Click);
            // 
            // courseList
            // 
            this.courseList.FormattingEnabled = true;
            this.courseList.Location = new System.Drawing.Point(18, 29);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(133, 212);
            this.courseList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addCourseLbl);
            this.groupBox4.Controls.Add(this.topicBox);
            this.groupBox4.Controls.Add(this.creditsBox);
            this.groupBox4.Controls.Add(this.idBox);
            this.groupBox4.Controls.Add(this.teacherCmbBox);
            this.groupBox4.Controls.Add(this.addCourseBtn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(570, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 278);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add new course";
            // 
            // addCourseLbl
            // 
            this.addCourseLbl.AutoSize = true;
            this.addCourseLbl.Location = new System.Drawing.Point(6, 247);
            this.addCourseLbl.Name = "addCourseLbl";
            this.addCourseLbl.Size = new System.Drawing.Size(22, 13);
            this.addCourseLbl.TabIndex = 5;
            this.addCourseLbl.Text = "     ";
            // 
            // topicBox
            // 
            this.topicBox.Location = new System.Drawing.Point(83, 78);
            this.topicBox.Name = "topicBox";
            this.topicBox.Size = new System.Drawing.Size(100, 20);
            this.topicBox.TabIndex = 8;
            // 
            // creditsBox
            // 
            this.creditsBox.Location = new System.Drawing.Point(83, 116);
            this.creditsBox.Name = "creditsBox";
            this.creditsBox.Size = new System.Drawing.Size(100, 20);
            this.creditsBox.TabIndex = 7;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(83, 40);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 20);
            this.idBox.TabIndex = 6;
            // 
            // teacherCmbBox
            // 
            this.teacherCmbBox.FormattingEnabled = true;
            this.teacherCmbBox.Location = new System.Drawing.Point(88, 160);
            this.teacherCmbBox.Name = "teacherCmbBox";
            this.teacherCmbBox.Size = new System.Drawing.Size(95, 21);
            this.teacherCmbBox.TabIndex = 5;
            // 
            // addCourseBtn
            // 
            this.addCourseBtn.Location = new System.Drawing.Point(45, 198);
            this.addCourseBtn.Name = "addCourseBtn";
            this.addCourseBtn.Size = new System.Drawing.Size(105, 32);
            this.addCourseBtn.TabIndex = 4;
            this.addCourseBtn.Text = "Add a course";
            this.addCourseBtn.UseVisualStyleBackColor = true;
            this.addCourseBtn.Click += new System.EventHandler(this.addCourseBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Topic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(606, 309);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(124, 34);
            this.logoutBtn.TabIndex = 10;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 364);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "AdminForm";
            this.Text = "School Management System - Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dropStudentBtn;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dropTeacherBtn;
        private System.Windows.Forms.ListBox teacherList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dropCourseBtn;
        private System.Windows.Forms.ListBox courseList;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox topicBox;
        private System.Windows.Forms.TextBox creditsBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.ComboBox teacherCmbBox;
        private System.Windows.Forms.Button addCourseBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label dropStudentLbl;
        private System.Windows.Forms.Label dropTeacherLbl;
        private System.Windows.Forms.Label dropCourseLbl;
        private System.Windows.Forms.Label addCourseLbl;
    }
}