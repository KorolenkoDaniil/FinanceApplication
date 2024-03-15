using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes.Wallets
{
    public class Wallet
    {
        private string name;
        private decimal amount;
        private int userId;

        public Wallet (string name, decimal amount, int userId)
        {
            this.name = name;
            this.amount = amount;
            this.userId = userId;
        }
        public Wallet () { }


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

        public override string ToString() => $"{name} {amount} {UserID}";

    }
}
