// teacher, inherits from user

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class Teacher : User
    {
        private Degree degree;

        public Degree Degree { get =>degree; set => degree = value; }

        public Teacher(string userID, string password, string name, string email,
            string address, string phone, Degree degree) :
            base(userID, password, name, email, address, phone)
        {
            this.degree = degree;
        }

        public override void showForm()
        {
            TeacherForm form = new TeacherForm();
            form.Show();
        }
    }
}
