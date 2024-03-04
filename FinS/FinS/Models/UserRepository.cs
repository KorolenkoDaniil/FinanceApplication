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

        public User SaveUser(User user)
        {
            UserDB.Insert(user);
            User foundUser = UserDB.Table<User>().FirstOrDefault(u => u.Email == user.Email);
            return foundUser;
        }

        public User SearchByEmailAndPassword(string email, string password)
        {
            User foundUser = UserDB.Table<User>().FirstOrDefault(u => u.Email == email && u.Password == password);
            return foundUser;
        }



    }
}
