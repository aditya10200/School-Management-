// here is the first window

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class StartForm : Form
    {
        // READ DATA FROM FILES (as in lab10) -- checking if files exist
        public StartForm()
        {
            InitializeComponent();
            Program.mainForm = this;
            this.CenterToScreen();

            // read all data here
            string[] lines;
            var pathUsers = Config.pathUsers;
            var pathCourses = Config.pathCourses;
            var pathMarks = Config.pathMarks;

            // reading data from users
            if (File.Exists(pathUsers))
            {
                lines = File.ReadAllLines(pathUsers);
                foreach (string line in lines)
                {
                    if (!line.StartsWith("User ID")) // skip headings
                    {
                        string[] info = line.Split(',');
                        switch (info[0])
                        {
                            case "admin":
                                Program.admins.Add(info[1],
                                    new Admin(info[1], info[2], info[3], info[4], info[5], info[6]));
                                break;
                            case "teacher":
                                Program.teachers.Add(info[1],
                                    new Teacher(info[1], info[2], info[3], info[4], info[5], info[6],
                                                info[7].toDegree()));
                                break;
                            case "student":
                                Program.students.Add(info[1],
                                    new Student(info[1], info[2], info[3], info[4], info[5], info[6], Mark.none));
                                break;
                        }
                    }
                }
            }

            // reading data from courses
            if (File.Exists(pathCourses))
            {
                lines = File.ReadAllLines(pathCourses);
                foreach (string line in lines)
                {
                    if (!(line.StartsWith("Course ID")))    // skip header
                    {
                        string[] info = line.Split(',');

                        // find teacher managing course
                        if (Program.teachers.ContainsKey(info[3]))
                        {
                            Program.courses.Add(info[0],
                                new Course(info[0], info[1], int.Parse(info[2]), Program.teachers[info[3]]));

                        }
                    }
                }
            }

            // reading all data from marks
            if (File.Exists(pathMarks))
            {
                lines = File.ReadAllLines(pathMarks);
                foreach (string line in lines)
                {
                    if (!(line.StartsWith("Student ID")))   // skip header
                    {
                        string[] info = line.Split(',');
                        Program.marks.Add(new MarkKey(info[0], info[1]), info[2].toMark());
                    }
                }
            }

            // now calculating GPAs for students
            foreach (Student student in Program.students.Values)
            {
                student.CalculateGPA(Program.marks);
            }
        }

        // choose login
        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        // choose register
        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        // WRITE DATA TO FILES
        // in the end, when clicked logout
        private void writeToFiles()
        {
            // file of users
            List<string> data = new List<string>();
            data.Add("User Type,User ID,Password,Name,Email,Address,Phone,[Other fields]");
            foreach (Admin admin in Program.admins.Values)
            {
                data.Add("admin," + admin.UserID + "," + admin.Password + "," + admin.Name + ","
                        + admin.Email + "," + admin.Address + "," + admin.Phone);
            }
            foreach (Teacher teacher in Program.teachers.Values)
            {
                data.Add("teacher," + teacher.UserID + "," + teacher.Password + "," + teacher.Name + ","
                        + teacher.Email + "," + teacher.Address + "," + teacher.Phone + "," +
                        teacher.Degree.ToString());
            }
            foreach (Student student in Program.students.Values)
            {
                data.Add("student," + student.UserID + "," + student.Password + "," + student.Name + ","
                        + student.Email + "," + student.Address + "," + student.Phone);
            }
            File.WriteAllLines(Config.pathUsers, data);

            // file of courses
            data.Clear();
            data.Add("Course ID,topic,credits,teacher ID");
            foreach (Course course in Program.courses.Values)
            {
                data.Add(course.CourseID + "," + course.Topic + "," + course.Credits.ToString() + ","
                            + course.TeacherID.UserID);
            }
            File.WriteAllLines(Config.pathCourses, data);

            // file of marks
            data.Clear();
            data.Add("Student ID, Course ID, Mark");
            foreach (MarkKey key in Program.marks.Keys)
            {
                data.Add(key.StudentID + "," + key.CourseID + "," + Program.marks[key].ToString());
            }
            File.WriteAllLines(Config.pathMarks, data);
        }

        // quit all -- call write data
        private void quitBtn_Click(object sender, EventArgs e)
        {
            // write everything to file!
            writeToFiles();
            // clean
            this.Dispose();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        // will simply return
        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
