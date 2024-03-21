using FinanceApp.classes.Color;
using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
using System.Collections.Generic;

namespace FinanceApp.classes
{
    public class Context
    {
        public User User { get; private set; }
        public List<Wallet> Wallets { get; private set; }
        public ColorClass Color { get; private set; }

        public void ChangeTheme(ColorClass color)
        {
            Color = color;
        }

        public void ChangeUser(User user)
        {
            User = user;
        }

        public void SetWalletsCollection(List<Wallet> wallets)
        {
            Wallets = wallets;
        }

    }
}
