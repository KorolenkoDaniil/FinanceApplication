using SQLite;
namespace FinS.Models
{
    [Table("Users")]
    public class User
    {
        [AutoIncrement, PrimaryKey]
        public int Id { get; set; }
        public int Theme { get; set; }
        public string Name { get; set; }

        [Unique]
        public string Email { get; set; }
        public string Password { get; set; }


        public User() { }
        public User(string name, string email, string password, int theme)
        {
            Name = name; Email = email;
            Password = password; Theme = theme;
        }
        public User(int id, string name, string email, string password, int theme)
        {
            Id = id;
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
