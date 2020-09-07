// a small window opened by registration window, does nothing

using System;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class RegistrationOKForm : Form
    {
        public RegistrationOKForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
