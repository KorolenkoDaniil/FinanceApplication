using SQLite;

namespace FinS.Models
{
    public class WalletRepository
    {
        string pathToUserDB;
        SQLiteConnection UserDB;

        public WalletRepository()
        {
            pathToUserDB = "D://FinAppDataBases//Users.db";
            UserDB = new SQLiteConnection(pathToUserDB);
            UserDB.CreateTable<Wallet>();
        }

        public bool Savewallet(Wallet wallet)
        {
            if (UserDB.Insert(wallet) != 0) return true;
            else return false; 
        }


        public List<Wallet> SearchByUserID(int userId)
        {
            Console.WriteLine(userId + "!!!!!!!!");
            List<Wallet> UsersWalletList = UserDB.Table<Wallet>().Where(u => u.UserId == userId).ToList();
            //foreach (Wallet walet in UsersWalletList)
            //{
            //    Console.WriteLine(walet);
            //}
            return UsersWalletList;
        }


    }
}
