using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.classes.User
{
    public static class UserRepository
    {
        private static readonly HttpClient client = new HttpClient();


        static UserRepository() { }

        public async static Task<bool> SaveUser(User newUser)
        {
            string json = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(Links.Registration, content);

            if (response.IsSuccessStatusCode) return true;
            return false;
        }
    }
}

