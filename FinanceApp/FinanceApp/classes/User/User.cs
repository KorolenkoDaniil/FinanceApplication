using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp.classes.User
{
    public class User
    {
        private string name;
        private int id;
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
               name = value;
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
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
