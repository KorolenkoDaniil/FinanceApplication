using SQLite;

namespace FinS.Models
{
    public class ColorRepository
    {
        string pathToColorDB;
        SQLiteConnection ColorDB;

        public ColorRepository()
        {
            pathToColorDB = "D://FinAppDataBases//Users.db";
            ColorDB = new SQLiteConnection(pathToColorDB);
            ColorDB.CreateTable<ColorClass>();
        }


        public ColorClass SearchById(int colorId)
        {
            Console.WriteLine(colorId.ToString() + "  цвет");
            ColorClass foundUser = ColorDB.Table<ColorClass>().FirstOrDefault(u => u.Id == colorId);
            return foundUser;
        }
    }
}
