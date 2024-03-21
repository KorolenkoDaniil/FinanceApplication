using System;
using System.ComponentModel;

namespace FinanceApp.classes.FinanceOpertaion
{
    class Operation
    {
        public int Id { get; private set; }
        public int UserID { get; private set; }
        public DateTime Date { get; private set; }
        public bool Profit { get; private set; }
        public decimal Sum { get; private set; }
        public string Wallet { get; private set; }
        public string Cathegory { get; private set; }
        public string Description { get; private set; }

        public Operation() { }
        public Operation(int userId, DateTime date, bool profit, decimal sum, string wallet, string cathegory, string description)
        {
            UserID = userId;
            Date = date;
            Wallet = wallet;
            Sum = sum;
            Profit = profit;
            Cathegory = cathegory;
            Description = description;
        }
        public override string ToString() => $"{Id} {UserID} {Date} {Profit} {Sum} {Wallet} {Cathegory} {Description}";
       
    }
}
