// print student form -- his courses, available courses, profile

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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            // hide password chars
            passwordBox.UseSystemPasswordChar = true;

            // set all boxes printing info (they will be updated)
            TextBox[] infoBoxes = new TextBox[] {
                availTopicBox, availCreditsBox, availTeacherBox,
                enrolledTopicBox, enrolledCreditsBox, enrolledTeacherBox
            };

            // set many line text boxes
            foreach (TextBox box in infoBoxes)
            {
                box.ScrollBars = ScrollBars.Vertical;
                box.ReadOnly = true;
            }

            // print everything
            refresh();
        }

        // reprint all
        private void refresh()
        {
            // get current student info
            Student student = (Student)Program.currentUser;

            // show available courses
            var courses = Program.courses.Where(pair => (
                  !Program.marks.ContainsKey(new MarkKey(student.UserID, pair.Key)))). 
                                    Select(pair => pair.Key);
                             
            if (courses.Count() > 0)
            {
                availableCoursesList.DataSource = new BindingSource(courses, null);
                availableCoursesList.Enabled = true;
            }
            else
            {
                string[] values = { "No courses yet" };
                availableCoursesList.DataSource = new BindingSource(values, null);
                availableCoursesList.SetSelected(0, false);
                availableCoursesList.Enabled = false;
            }

            // show signed courses with current marks

            var marks = Program.marks.Where(pair => (pair.Key.StudentID.Equals(student.UserID))).
                        Select(pair => (pair.Key.CourseID + ":" + pair.Value));

            if (marks.Count() > 0)
            {
                enrolledCoursesList.DataSource = new BindingSource(marks, null);
                enrolledCoursesList.Enabled = true;
            }
            else 
            {
                string[] values = { "No courses yet" };
                enrolledCoursesList.DataSource = new BindingSource(values, null);
                enrolledCoursesList.SetSelected(0, false);
                enrolledCoursesList.Enabled = false;
            }

            // show personal profile:

            idBox.Text = student.UserID;
            idBox.Enabled = false;
            passwordBox.Text = student.Password;
            nameBox.Text = student.Name;
            emailBox.Text = student.Email;
            addressBox.Text = student.Address;
            phoneBox.Text = student.Phone;
            gpaBox.Text = student.GPA.ToString();
            gpaBox.Enabled = false;
        }

        // add another course
        private void signCourseBtn_Click(object sender, EventArgs e)
        {
            if (availableCoursesList.SelectedIndex != -1 &&
                Program.courses.ContainsKey(availableCoursesList.Get()))
            {
                // firstly clean all previous messages
                signResultLbl.Text = "";
                dropResultLbl.Text = "";
                updStudLbl.Text = "";

                // process this one
                Course selectedCourse = Program.courses[availableCoursesList.Get()];
                Student student = (Student)Program.currentUser;
                // check that we already do not have that course (should not)
                if (Program.marks.ContainsKey(new MarkKey(student.UserID, selectedCourse.CourseID)))
                {
                    signResultLbl.Text = "Some error: already signed";
                }
                else
                {
                    Program.marks.Add(new MarkKey(student.UserID, selectedCourse.CourseID),
                        Mark.none);
                    signResultLbl.Text = "Signed to the course";
                }
                refresh();
            }
        }

        // remove my course
        private void dropCourseBtn_Click(object sender, EventArgs e)
        {
            if (enrolledCoursesList.SelectedIndex != -1 &&
                Program.courses.ContainsKey(enrolledCoursesList.Get().substringToChar(':')))
            {
                // firstly clean all previous messages
                signResultLbl.Text = "";
                dropResultLbl.Text = "";
                updStudLbl.Text = "";

                // process this one
                // get course ID, student ID and mark
                string studentID = Program.currentUser.UserID;
                string courseID = enrolledCoursesList.Get().substringToChar(':');

                // check that we already are not unenrolled from that course (should not)
                if (!Program.marks.ContainsKey(new MarkKey(studentID, courseID)))
                {
                    dropResultLbl.Text = "Some error: not signed";
                }
                else
                {
                    Mark mark = Program.marks[new MarkKey(studentID, courseID)];
                    if (mark != Mark.none)
                    {
                        dropResultLbl.Text = "Cannot drop course with mark";
                    }
                    else
                    {
                        Program.marks.Remove(new MarkKey(studentID, courseID));
                        dropResultLbl.Text = "Unenrolled from the course";
                    }
                }
                refresh();
            }
        }

        // update my profile info
        private void updateBtn_Click(object sender, EventArgs e)
        {
            // firstly clean all previous messages
            signResultLbl.Text = "";
            dropResultLbl.Text = "";
            updStudLbl.Text = "";

            // process this one
            Student student = (Student)Program.currentUser;
            string password = passwordBox.Text.Trim();
            string name = nameBox.Text.Trim();
            string email = emailBox.Text.Trim();
            string address = addressBox.Text.Trim();
            string phone = phoneBox.Text.Trim();

            // check errors
            if (password.Equals("") || password.Contains(",") || 
                name.Equals("") || name.Contains(",") ||
                email.Equals("") || email.Contains(",") ||
                address.Equals("") || address.Contains(",") ||
                phone.Equals("") || phone.Contains(","))
            {
                updStudLbl.Text = "Fill all values and don't use commas (,)";
            }
            else
            // perform update
            {
                student.Password = password;
                student.Name = name;
                student.Email = email;
                student.Address = address;
                student.Phone = phone;
            }
            refresh();
        }

        // return to start form
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }

        // update printed info
        private void availableCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update currently selected course
            if (availableCoursesList.SelectedIndex != -1 &&
                Program.courses.ContainsKey(availableCoursesList.Get()))
            {
                Course selectedCourse = Program.courses[availableCoursesList.Get()];

                // set values
                availTopicBox.Text = selectedCourse.Topic;
                availTeacherBox.Text = selectedCourse.TeacherID.UserID;
                availCreditsBox.Text = selectedCourse.Credits.ToString();
            }
        }

        // update printed info
        private void enrolledCoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // current course ID
            string courseID;
            // update currently selected course
            if (enrolledCoursesList.SelectedIndex != -1 &&
                (courseID = enrolledCoursesList.Get().substringToChar(':')) != null &&
                Program.courses.ContainsKey(courseID))
            {
                Course selectedCourse = Program.courses[courseID];

                // set values
                enrolledTopicBox.Text = selectedCourse.Topic;
                enrolledTeacherBox.Text = selectedCourse.TeacherID.UserID;
                enrolledCreditsBox.Text = selectedCourse.Credits.ToString();
            }
        }

        // return to start window when closed
        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }
    }
}
