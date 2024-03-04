using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinanceApp.classes
{
    internal static class Validator
    {
        public static bool ValidateName(string value, int max_size)
        {
            if (string.IsNullOrEmpty(value)) return false;

            if (value.Length > max_size) return false;

            return true;
        }

        public static bool ValidateEmail(string value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            Regex regex = new Regex(@"@gmail.com");

            if (!regex.IsMatch(value)) return false;
            
            return true;
        }

        public static bool ValidateId(int value)
        {
            if (value < 0) return false;
            return true;
        }
    }
}
