// Admin, one of user types -- inherits from User

namespace SchoolManagement
{
    class Admin : User
    {
        public Admin(string userID, string password, string name, string email,
            string address, string phone) :
            base(userID, password, name, email, address, phone)
        {
            // nothing to do
        }

        public override void showForm()
        {
            AdminForm form = new AdminForm();
            form.Show();
        }
    }
}
