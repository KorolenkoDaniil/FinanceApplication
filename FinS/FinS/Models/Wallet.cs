using SQLite;

namespace FinS.Models
{
    [Table("Wallets")]
    public class Wallet
    {
        private string name;
        private decimal amount;
        private int userId;
        private string type;
        private int sign;
        private int color;
        private bool includeOrNot;

        public Wallet(string name, decimal amount, int userId,
            string type, int sign, int color, bool includeOrNot)
        {
            this.name = name;
            this.amount = amount;
            this.userId = userId;
            this.type = type;
            this.sign = sign;
            this.color = color;
            this.includeOrNot = includeOrNot;
        }
        public Wallet() { }


        public int UserID
        {
            get => userId;
            set => userId = value;
        }

        public decimal Amount
        {
            get => amount;
            set => amount = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public int Sign
        {
            get => sign;
            set => sign = value;
        }
        public int Color
        {
            get => color;
            set => color = value;
        }

        public bool IncludeOrNot
        {
            get => includeOrNot;
            set => includeOrNot = value;
        }

        public override string ToString() => $"{name} {amount} {UserID}";

    }
}
