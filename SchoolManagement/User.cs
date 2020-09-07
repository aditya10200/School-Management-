//
// most generic user class
// from it admin, teacher and student inherit

namespace SchoolManagement
{
    abstract class User
    {
        protected string userID;    // main data shown in all profiles
        protected string password;
        protected string name;
        protected string email;
        protected string address;
        protected string phone;

        public string UserID { get => userID; set => userID = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }

        public User(string userID, string password, string name, string email, string address, string phone)
        {
            this.userID = userID;
            this.password = password;
            this.name = name;
            this.email = email;
            this.address = address;
            this.phone = phone;
        }

        // this is as polymorphism example -- all user types implement it as they want,
        // and while login the current user (of type User) chooses appropriate version
        public abstract void showForm();
    }
}
