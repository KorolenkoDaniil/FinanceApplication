using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
using System.Collections.Generic;

namespace FinanceApp.classes
{
    public class Context
    {
        private User user;
        private List<Wallet> wallets;
        public User User { get => user; set => user = value; }
        public List<Wallet> Wallets { get => wallets; set => wallets = value; }
    }
}
