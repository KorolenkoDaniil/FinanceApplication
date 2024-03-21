using SQLite;

namespace FinS.Models
{
    [Table("Wallets")]
    public class Wallet
    {
        public Wallet () { }
        public Wallet(string name, decimal amount, int userId, string type, int color, bool include)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentException();

            if (string.IsNullOrEmpty(type) || string.IsNullOrWhiteSpace(type))
                throw new ArgumentException();
            
            if (color < 0 || amount < 0)
                throw new ArgumentException();

            Name = name;
            Amount = amount;
            UserId = userId;
            Include = include;
            Type = type;
            Color = color;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int UserId { get; set; }
        public int Color { get; set; }
        public bool Include { get; set; }

        public override string ToString() => $"{Name} {Amount} {UserId}";
    }
}
