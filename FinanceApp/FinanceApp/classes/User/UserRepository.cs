using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

namespace FinanceApp.classes.User
{
    public static class UserRepository
    {
        private static readonly HttpClient client = new HttpClient();


        static UserRepository() { }

        public async static void SaveUser(User newUser)
        {
            string json = JsonConvert.SerializeObject(newUser);

            using (var content = new MultipartFormDataContent())
            {
                // Добавляем JSON-строку как контент
                content.Add(new StringContent(json), "user", "UserInJSON.json");

                HttpResponseMessage response = await client.PostAsync(Links.Registration, content);
            }
        }
    }
}

