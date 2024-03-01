using SQLite;

namespace FinS.Models
{
    [Table("Users")]
    public class User
    {
        private int id;
        private string? name;
        private string? email;
        private string? password;
        private string? theme;

        public User() { }
        public User(string name, string email, string password, string theme)
        {
            Name = name;
            Email = email;
            Password = password;
            Theme = theme;
        }


        [AutoIncrement, PrimaryKey]
        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        
        public string Name
        {
            get => name;

            set { name = value; }
        }
        public string Email
        {
            get => email;
            set { email = value; }
        }
        public string Password
        {
            get => password;
            set { password = value; }
        }
        public string Theme
        {
            get => theme;
            set
            {
                theme = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Email} {Password}";
        }
    }
}
