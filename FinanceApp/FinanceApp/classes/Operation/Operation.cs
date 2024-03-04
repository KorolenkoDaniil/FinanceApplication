using System;

namespace FinanceApp.classes.FinanceOpertaion
{
    class Operation
    {
        private int id;
        private int userId;
        private DateTime date;
        private bool type;
        private decimal sum;
        private string wallet;
        private string cathegory;
        private string description;
     

        public Operation() { }
        //public Operation()
        //{
          
        //}


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

        public bool Type
        {
            get => type;
            set => type = value;
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



        public override string ToString() => $"";
       
    }
}
