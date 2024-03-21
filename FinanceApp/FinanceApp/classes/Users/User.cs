namespace FinanceApp.classes.Users
{
    public class User
    {
        public int Id { get; set; }
        public int Theme { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
       
        public User() { }
        public User(string name, string email, string password, int theme)
        {
            Name = name;
            Email = email;
            Password = password;
            Theme = theme;
        }

        public override string ToString()
        {
            return $"{Name} {Email} {Password} {Id}";
        }
    }
}
