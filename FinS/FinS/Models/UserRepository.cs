using SQLite;

namespace FinS.Models
{
    public class UserRepository
    {
        string pathToUserDB;
        SQLiteConnection UserDB;

        public UserRepository()
        {
            pathToUserDB = "D://FinAppDataBases//Users.db";
            UserDB = new SQLiteConnection(pathToUserDB);
            UserDB.CreateTable<User>();
        }

        public void SaveUser(User user)
        {
            UserDB.Insert(user);
        }
    }
}
