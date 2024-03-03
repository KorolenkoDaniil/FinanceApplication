using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes
{
    public static class DateConverter
    {
        public static DateTime Converter(string data)
        {
            Console.WriteLine(data + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!11");
            if (data.Contains("ЯНВ")) return new DateTime(DateTime.Now.Year, 1, 1);
            else if (data.Contains("ФЕВР"))  return new DateTime(DateTime.Now.Year, 2, 1);
            else if (data.Contains("МАРТ"))  return new DateTime(DateTime.Now.Year, 3, 1);
            else if (data.Contains("АПР"))  return new DateTime(DateTime.Now.Year, 4, 1);
            else if (data.Contains("МАЙ"))  return new DateTime(DateTime.Now.Year, 5, 1);
            else if (data.Contains("ИЮНЬ"))  return new DateTime(DateTime.Now.Year, 6, 1);
            else if (data.Contains("ИЮЛЬ"))  return new DateTime(DateTime.Now.Year, 7, 1);
            else if (data.Contains("АВГ"))  return new DateTime(DateTime.Now.Year, 8, 1);
            else if (data.Contains("СЕНТ"))  return new DateTime(DateTime.Now.Year, 9, 1);
            else if (data.Contains("ОКТ"))  return new DateTime(DateTime.Now.Year, 10, 1);
            else if (data.Contains("НОЯБ"))  return new DateTime(DateTime.Now.Year, 11, 1);
            else if (data.Contains("ДЕК"))  return new DateTime(DateTime.Now.Year, 12, 1);
            else return new DateTime(DateTime.Now.Year, 1, 1);
        }
    }
}
