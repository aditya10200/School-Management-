// login form

using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            /* set possible values to combobox */
            string[] values = { "Student", "Teacher", "Administrator" };
            loginCmbBox.DataSource = values;
            loginCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // password chars
            passwordBox.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // try to login
        private void loginBtn_Click(object sender, EventArgs e)
        {
            Program.currentUser = null;
            string userID = userIDBox.Text;
            string password = passwordBox.Text;
            string type = loginCmbBox.Text;

            // determine who is login and check is they exist
            switch (type)
            {
                case "Student":
                    var student = Program.students.Where(pair => (pair.Key.Equals(userID) && 
                                            pair.Value.Password.Equals(password))).
                                  Select(pair => pair.Value);
                    if (student.Count() != 0)
                    {
                        Program.currentUser = student.First();
                    } 
                    else
                    {
                        resultLbl.Text = "Either user ID or password incorrect";
                    }
                    break;
                case "Teacher":
                    var teacher = Program.teachers.Where(pair => (pair.Key.Equals(userID) &&
                                            pair.Value.Password.Equals(password))).
                                    Select(pair => pair.Value);
                    if (teacher.Count() != 0)
                    {
                        Program.currentUser = teacher.First();
                    }
                    else
                    {
                        resultLbl.Text = "Either user ID or password incorrect";
                    }
                    break;
                case "Administrator":
                    var admin = Program.admins.Where(pair => (pair.Key.Equals(userID) &&
                                            pair.Value.Password.Equals(password))).
                                    Select(pair => pair.Value);
                    if (admin.Count() != 0)
                    {
                        Program.currentUser = admin.First();
                    }
                    else
                    {
                        resultLbl.Text = "Either user ID or password incorrect";
                    }
                    break;
            }
            // if user was not changed -- error happened
            if (Program.currentUser == null)
                return;


            // now launch needed form using polymorphism (in real large app
            //   there can be more configuration of child classes invoked in one call)
            Program.currentUser.showForm();
            this.Dispose();
        }

        // return to start window
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }

        // similar
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }
    }
}
