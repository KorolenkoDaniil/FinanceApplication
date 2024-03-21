using FinanceApp.classes.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes.Wallets
{
    public class Wallet
    {
        public string Type { get; private set; }
        public string Name { get; private set; }
        public decimal Amount { get; private set; }
        public int UserId { get; private set; }
        public int Color { get; private set; }
        public bool Include { get; private set; }
        public int Id { get; private set; }


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
        public override string ToString() => $"{Name} {Amount} {UserId}";

    }
}
