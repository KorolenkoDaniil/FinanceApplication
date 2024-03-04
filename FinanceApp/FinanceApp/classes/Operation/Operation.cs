using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes.FinanceOpertaion
{
    class Operation
    {
        private string name;
        private int id;
        private string email;
        private string password;
        private string theme;

        public Operation() { }
        public Operation(string name, string email, string password, string theme)
        {
            Name = name;
            Email = email;
            Password = password;
            Theme = theme;
        }


        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        public string Theme
        {
            get => theme;
            set
            {
                theme = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (Validator.ValidateName(value, 30)) name = value;
                else { throw new Exception("никнейм не прошел проверку"); }
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (Validator.ValidateEmail(value)) email = value;
                else { throw new Exception("проверьте введенную почту"); }
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
            }
        }


        public override string ToString()
        {
            return $"{Name} {Email} {Password} {Id}";
        }
    }
}
