using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.classes.Users
{
    public static class UserRepository
    {
        private static readonly HttpClient client = new HttpClient();


        static UserRepository() { }

        public async static Task<User> SaveUser(User newUser)
        {
            string json = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(Links.Registration, content);

            if (response.IsSuccessStatusCode)
            {
                string answer = await response.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(answer);
                return user;
            }
            else
            {
                Console.WriteLine($"Ошибка при получении данных: {response.StatusCode}");
                return null;
            }   
        }



        public async static Task<User> AuthoriseUser(string email, string password)
        {
            Dictionary<string, string> UserData = new Dictionary<string, string>
            {
                {"email", email},
                {"password", password}
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(UserData);
            HttpResponseMessage response = await client.PostAsync(Links.Authorisation, form);

            if (response.IsSuccessStatusCode) {
                string answer = await response.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(answer);
                
                return user;
            }
            else
            {
                Console.WriteLine($"Ошибка при получении данных: {response.StatusCode}");
                return null;
            }
           
        }
      
    }
}

