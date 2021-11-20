

namespace CorrectionCC1.WinForms
{
    public class UserList
    {
        public string Email { get; set; }
        public string Fullname { get; set; }

        public UserList(string email, string fullname)
        {
            Email = email;
            Fullname = fullname;
        }
    }
}
