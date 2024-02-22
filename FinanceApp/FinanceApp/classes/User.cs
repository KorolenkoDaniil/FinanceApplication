﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes
{
    public class User
    {
        private string name;
        private string email;
        private string password;
        private string theme;

        public User() { }
        public User(string name, string email, string password, string theme)
        {
            Name = name;
            Email = email;
            Password = password;
            Theme = theme;
        }
        public string Theme
        {
            get => theme;
            set
            {
                theme = value;
            }
        }
        public string Name {
            get => name;
            set 
            {
                if (Validator.ValidateName(value, 30)) name = value;
                else { throw new Exception("никнейм не прошел проверку");}
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
        public string Password {
            get => password;
            set
            {
                password = value;
            }
        }
    }
}
