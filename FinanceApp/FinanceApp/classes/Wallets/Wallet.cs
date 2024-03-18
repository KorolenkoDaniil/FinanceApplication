using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes.Wallets
{
    public class Wallet
    {
        private int id;
        private string name;
        private decimal amount;
        private int userId;
        private string type;
        private int color;
        private bool include;


        public Wallet (string name, decimal amount, int userId, string type, int color, bool include )
        {
            Name = name;
            Amount = amount;
            UserId = userId;
            Include = include;
            Type = type;
            Color = color;
        }
        public Wallet () { }


       
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public decimal Amount { get => amount; set => amount = value; }
        public int UserId { get => userId; set => userId = value; }
        public int Color { get => color; set => color = value; }
        public bool Include { get => include; set => include = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString() => $"{Name} {Amount} {UserId}";

    }
}
