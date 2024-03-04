namespace FinS.Models
{
    class Operation
    {
        private int id;
        private int userId;
        private DateTime date;
        private bool profit;
        private decimal sum;
        private string wallet;
        private string cathegory;
        private string description;


        public Operation() { }
        public Operation(int id, int userId, DateTime date, bool profit, decimal sum, string wallet, string cathegory, string description)
        {
            Id = id;
            UserID = userId;
            Date = date;
            Wallet = wallet;
            Sum = sum;
            Profit = profit;
            Cathegory = cathegory;
            Description = description;
        }


        public int Id
        {
            get => id;
            set => id = value;
        }

        public int UserID
        {
            get => userId;
            set => userId = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public bool Profit
        {
            get => profit;
            set => profit = value;
        }

        public decimal Sum
        {
            get => sum;
            set => sum = value;
        }

        public string Wallet
        {
            get => wallet;
            set => wallet = value;
        }

        public string Cathegory
        {
            get => cathegory;
            set => cathegory = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }



        public override string ToString() => $"{Id} {UserID} {Date} {Profit} {Sum} {Wallet} {Cathegory} {Description}";
    }
}
