// print teacher form -- his courses, and marks for his students, and his profile

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
    
    public partial class TeacherForm : Form
    {

        public TeacherForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            // set possible values for combobox of degrees
            string[] degrees = { "BD", "MD", "PhD", "none" };
            degreeCmbBox.DataSource = degrees;
            degreeCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // and combobox of marks
            string[] marks = { "A", "B", "C", "D", "E", "F", "none" };
            markCmbBox.DataSource = marks;
            markCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;
            markCmbBox.Enabled = false;

            // cannot set mark before choosing a course and student
            updMarkBtn.Enabled = false;

            // hide password chars
            passwordBox.UseSystemPasswordChar = true;

            // put label boxes for courses to scrollbars
            // set all boxes printing info (they will be updated)
            TextBox[] infoBoxes = new TextBox[] {
                creditsBox, topicBox
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
            // show my courses
            Teacher teacher = (Teacher)Program.currentUser;
            var result = Program.courses.Where(pair => (pair.Value.TeacherID.Equals(teacher))).
                            Select(pair => pair);
            if (result.Count() > 0)
            {
                courseListBox.DataSource = new BindingSource(result, null);
                courseListBox.ValueMember = "Key";
                courseListBox.Enabled = true;
            }
            else
            {
                string[] values = { "You do not teach any courses" };
                courseListBox.DataSource = new BindingSource(values, null);
                courseListBox.SetSelected(0, false);
                courseListBox.Enabled = false;

                updMarkBtn.Enabled = false;
                markCmbBox.Enabled = false;
            }

            // show personal profile
            idBox.Text = teacher.UserID;
            idBox.Enabled = false;
            passwordBox.Text = teacher.Password;
            nameBox.Text = teacher.Name;
            emailBox.Text = teacher.Email;
            addressBox.Text = teacher.Address;
            phoneBox.Text = teacher.Phone;
            degreeCmbBox.SelectedItem = teacher.Degree.ToString();

        }

        // update printed info
        private void courseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update currently selected course
            if (courseListBox.SelectedIndex != -1 &&
                Program.courses.ContainsKey(courseListBox.Get()))
            {
                Course selectedCourse = Program.courses[courseListBox.Get()];

                // set values for course itself
                topicBox.Text = selectedCourse.Topic;
                creditsBox.Text = selectedCourse.Credits.ToString();

                // and show all students taking it with their marks
                var result = Program.marks.Where(pair =>
                    (pair.Key.CourseID.Equals(selectedCourse.CourseID))).
                        Select(pair => (pair.Key.StudentID + ":" + pair.Value));
                if (result.Count() > 0)
                {
                    studMarkListBox.DataSource = new BindingSource(result, null);
                    studMarkListBox.Enabled = true;
                }
                else
                {
                    string[] values = { "No students take this course" };
                    studMarkListBox.DataSource = new BindingSource(values, null);
                    studMarkListBox.SetSelected(0, false);
                    studMarkListBox.Enabled = false;
                }
            }
        }

        // update student mark
        private void updMarkBtn_Click(object sender, EventArgs e)
        {
            // update currently selected course
            if (courseListBox.SelectedIndex != -1 &&
                Program.courses.ContainsKey(courseListBox.Get()) &&
                studMarkListBox.SelectedIndex != -1 &&
                studMarkListBox.Get().substringToChar(':') != null &&
                Program.students.ContainsKey(studMarkListBox.Get().substringToChar(':')))
            {
                // clear labels
                updTeacherLbl.Text = "";

                // get Course, Student and Mark
                string courseID = courseListBox.Get();
                string studentID = studMarkListBox.Get().substringToChar(':');
                Mark mark = markCmbBox.Get().toMark();

                // add to marks (Student_ID; Course_ID) => (Mark)
                Program.marks.Remove(new MarkKey(studentID, courseID));
                Program.marks.Add(new MarkKey(studentID, courseID), mark);
                updMarkLbl.Text = "Updated mark";

                // recalculate his GPA
                Program.students[studentID].CalculateGPA(Program.marks);

                // update GUI
                refresh();
            }
        }

        // update profile info
        private void studMarkListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (courseListBox.SelectedIndex != -1 &&
                Program.courses.ContainsKey(courseListBox.Get()) &&
                studMarkListBox.SelectedIndex != -1 &&
                studMarkListBox.Get().substringToChar(':') != null &&
                Program.students.ContainsKey(studMarkListBox.Get().substringToChar(':')))
            {
                updMarkBtn.Enabled = true;
                markCmbBox.Enabled = true;
            }
        }

        // update profile info
        private void updProfileBtn_Click(object sender, EventArgs e)
        {
            // clear other labels
            updMarkLbl.Text = "";
            updTeacherLbl.Text = "";

            // get data
            Teacher teacher = (Teacher)Program.currentUser;
            string password = passwordBox.Text.Trim();
            string name = nameBox.Text.Trim();
            string email = emailBox.Text.Trim();
            string address = addressBox.Text.Trim();
            string phone = phoneBox.Text.Trim();
            Degree degree = degreeCmbBox.Text.Trim().toDegree();

            // check errors
            if (password.Equals("") || password.Contains(",") ||
                name.Equals("") || name.Contains(",") ||
                email.Equals("") || name.Contains(",") ||
                address.Equals("") || address.Contains(",") ||
                phone.Equals("") || phone.Contains(","))
            {
                updTeacherLbl.Text = "Fill all values, and don't use commas (,)";
            }
            else
            // perform update
            {
                teacher.Password = password;
                teacher.Name = name;
                teacher.Email = email;
                teacher.Address = address;
                teacher.Phone = phone;
                teacher.Degree = degree;
            }
            refresh();
        }

        // return to start window
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }

        // exit on crossing -- return to start window
        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }
    }
}
