// register form
using System;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            this.CenterToScreen();

            // possible values for degree cmb box
            string[] values = { "BD", "MD", "PhD", "none" };
            degreeCmbBox.DataSource = values;
            degreeCmbBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // make password hide chars
            passwordBox.UseSystemPasswordChar = true;

            refresh();
        }

        // when small window closed -- delegate example in project
        public void ConfirmFormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }

        // reprint all
        private void refresh()
        {
            degreeCmbBox.Visible = teacherRadBtn.Checked;
            degreeLbl.Visible = teacherRadBtn.Checked;
        }

        // show small window
        private void confirmDialog()
        {
            // show confirm dialog
            RegistrationOKForm form = new RegistrationOKForm();

            // add delegate, so that after closing confirm form
            // we will close reg form as well and move to start page
            form.FormClosed += new FormClosedEventHandler(ConfirmFormClosed);
            form.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            /* check values are correct */
            string id = idBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string name = nameBox.Text.Trim();
            string email = emailBox.Text.Trim();
            string address = addressBox.Text.Trim();
            string phone = phoneBox.Text.Trim();
            string degree = degreeCmbBox.Text.Trim();

            if (id.Equals("") || id.Contains(",") || 
                password.Equals("") || password.Contains(",") ||
                name.Equals("") || name.Contains(",") ||
                email.Equals("") || email.Contains(",") ||
                address.Equals("") || address.Contains(",") ||
                phone.Equals("") || phone.Contains(","))
            {
                errorLbl.Text = "Please set all values and do not use commas (,)";
            }
            else if (teacherRadBtn.Checked)
            {
                if (Program.teachers.ContainsKey(id) || Program.students.ContainsKey(id) || 
                    Program.admins.ContainsKey(id))
                {
                    errorLbl.Text = "Such ID already in use";
                }
                else
                {
                    // add
                    Program.teachers.Add(id,
                        new Teacher(id, password, name, email, address, phone, 
                        degree.toDegree()));

                    confirmDialog();
                }
            }
            else    // student button checked
            {
                if (Program.students.ContainsKey(id) || Program.teachers.ContainsKey(id) ||
                        Program.admins.ContainsKey(id))
                {
                    errorLbl.Text = "Such ID already in use";
                }
                else
                {
                    // add
                    Program.students.Add(id, new Student(id, password, name, email,
                        address, phone, Mark.none));

                    confirmDialog();
                }
            }
        }

        // return to main wind. (start window)
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }

        // when click on different radio button, change degree field
        private void teacherRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            degreeCmbBox.Visible = teacherRadBtn.Checked;
            degreeLbl.Visible = teacherRadBtn.Checked;
        }

        private void studentRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            degreeCmbBox.Visible = teacherRadBtn.Checked;
            degreeLbl.Visible = teacherRadBtn.Checked;
        }

        // when closed this window -- return to start
        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Show();
            this.Dispose();
        }
    }
}
