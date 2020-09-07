// showing admin GUI
// Program.currentUser holds reference to admin

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            // print everything
            refresh();
        }

        // reprint all elements
        private void refresh()
        {
            // students registered
            if (Program.students.Count() > 0)
            {
                var results = Program.students.Select(pair =>
                    (pair.Value.UserID + ":" + pair.Value.GPA));

                studentList.DataSource = new BindingSource(results, null);
                studentList.Enabled = true;

                dropStudentBtn.Enabled = true;
            }
            else
            {
                string[] values = { "No students are registered yet" };
                studentList.DataSource = new BindingSource(values, null);
                studentList.SetSelected(0, false);
                studentList.Enabled = false;

                dropStudentBtn.Enabled = false;
            }

            // teachers registered
            if (Program.teachers.Count() > 0)
            {
                teacherList.DataSource = new BindingSource(Program.teachers, null);
                teacherList.ValueMember = "Key";
                teacherList.Enabled = true;

                dropTeacherBtn.Enabled = true;

                // also show them in combobox
                teacherCmbBox.DataSource = new BindingSource(Program.teachers, null);
                teacherCmbBox.ValueMember = "Key";
                teacherCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                string[] values = { "No teachers are registered yet" };
                teacherList.DataSource = new BindingSource(values, null);
                teacherList.SetSelected(0, false);
                teacherList.Enabled = false;

                dropTeacherBtn.Enabled = false;
            }

            // courses registered
            if (Program.courses.Count() > 0)
            {
                courseList.DataSource = new BindingSource(Program.courses, null);
                courseList.ValueMember = "Key";
                courseList.Enabled = true;

                dropCourseBtn.Enabled = true;
            }
            else
            {
                string[] values = { "No courses are opened yet" };
                courseList.DataSource = new BindingSource(values, null);
                courseList.SetSelected(0, false);
                courseList.Enabled = false;

                dropCourseBtn.Enabled = false;
            }
        }

        // remove a student from list
        private void dropStudentBtn_Click(object sender, EventArgs e)
        {
            string studentID;   // selected student

            if (studentList.SelectedIndex != -1 && 
                (studentID = studentList.Get().substringToChar(':')) != null &&
                Program.students.ContainsKey(studentID))
            {
                // clear other labels
                dropTeacherLbl.Text = "";
                dropCourseLbl.Text = "";
                addCourseLbl.Text = "";

                
                // now we must remove all marks of that student
                // 1) firstly find his marks' keys using linq
                var result = Program.marks.Where(pair => (pair.Key.StudentID.Equals(studentID))).
                                Select(pair => pair.Key).ToArray();

                // 2) then remove them one by one
                foreach (MarkKey key in result)
                    Program.marks.Remove(key);

                // and then remove student himself
                Program.students.Remove(studentID);

                dropStudentLbl.Text = "Student deleted";

                refresh();
            }
        }

        // remove a teacher from list
        private void dropTeacherBtn_Click(object sender, EventArgs e)
        {
            if (teacherList.SelectedIndex != -1 &&
                Program.teachers.ContainsKey(teacherList.Get()))
            {
                // clear other labels
                dropStudentLbl.Text = "";
                dropCourseLbl.Text = "";
                addCourseLbl.Text = "";

                // determine selected teacher
                string teacherID = teacherList.Get();

                // now we must remove all marks for students signed for his courses
                // firstly find all courses of his
                var courses = Program.courses.
                    Where(pair => (pair.Value.TeacherID.UserID.Equals(teacherID))).
                        Select(pair => pair.Key).ToArray();

                // now find all student marks related to any of them
                foreach (string courseID in courses)
                {
                    var marks = Program.marks.Where(pair => pair.Key.CourseID.Equals(courseID)).
                                        Select(pair => pair.Key).ToArray();
                    // delete marks for this course
                    foreach (MarkKey key in marks)
                        Program.marks.Remove(key);

                    // and remove this course
                    Program.courses.Remove(courseID);
                }

                // and then remove teacher himself
                Program.teachers.Remove(teacherID);

                // recalculate GPA of students
                foreach (Student student in Program.students.Values)
                    student.CalculateGPA(Program.marks);

                dropTeacherLbl.Text = "Teacher deleted";

                refresh();
            }
        }

        // remove a course from list
        private void dropCourseBtn_Click(object sender, EventArgs e)
        {
            if (courseList.SelectedIndex != -1 &&
                Program.courses.ContainsKey(courseList.Get()))
            {
                // clear other labels
                dropStudentLbl.Text = "";
                dropTeacherLbl.Text = "";
                addCourseLbl.Text = "";

                // determine selected course
                string courseID = courseList.Get();

                // now we must remove all marks for students signed for this course
                var marks = Program.marks.Where(pair => pair.Key.CourseID.Equals(courseID)).
                                        Select(pair => pair.Key).ToArray();
                
                // delete marks for this course
                foreach (MarkKey key in marks)
                     Program.marks.Remove(key);

                // and remove this course
                Program.courses.Remove(courseID);

                // recalculate GPA of students
                foreach (Student student in Program.students.Values)
                    student.CalculateGPA(Program.marks);

                dropCourseLbl.Text = "Course deleted";

                refresh();
            }
        }

        // remove a course from list
        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            // clear labels
            dropStudentLbl.Text = "";
            dropTeacherLbl.Text = "";
            dropCourseLbl.Text = "";

            // get data
            string courseID = idBox.Text.Trim();
            string topic = topicBox.Text.Trim();
            int credits;
            bool creditsOK = Int32.TryParse(creditsBox.Text, out credits);
            string teacherID = teacherCmbBox.Text.Trim();
            if (courseID.Equals("") || courseID.Contains(",") ||
                topic.Equals("") || topic.Contains(",") || 
                !creditsOK || credits <= 0 
                || teacherID.Equals("") || teacherID.Contains(",") || 
                !Program.teachers.ContainsKey(teacherID)
                || Program.courses.ContainsKey(courseID))
            {
                addCourseLbl.Text = "Fill data, don't use commas, credits>0";
            }
            else
            {
                Program.courses.Add(courseID,
                    new Course(courseID, topic, credits, Program.teachers[teacherID]));
                addCourseLbl.Text = "Added course successfully";
                refresh();
            }
        }

        // move to start window
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }

        // similar
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }
    }
} 
