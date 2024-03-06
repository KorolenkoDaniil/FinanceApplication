using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.classes.Wallet
{
    public static class WalletRepository
    {
        private static readonly HttpClient client = new HttpClient();

        static WalletRepository() { }
        public async static Task<bool> SaveWallet(Wallet newWallet)
        {
            string json = JsonConvert.SerializeObject(newWallet);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(Links.SaveWallet, content);

            if (response.IsSuccessStatusCode) return true;
            else return false;
        }


        public async static Task<List<Wallet>> GetWallets(int userId)
        {
            Console.WriteLine("4 !!!!!!!!!!!!!!");
            Dictionary<string, string> UserId = new Dictionary<string, string>
            {
                {"id", userId.ToString()}
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(UserId);
            HttpResponseMessage response = await client.PostAsync(Links.GetWallets, form);

            Console.WriteLine("5 !!!!!!!!!!!!!!");


            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("6 !!!!!!!!!!!!!!");
                string StringListWallets = await response.Content.ReadAsStringAsync();
                List<Wallet> UsersWalletList = JsonConvert.DeserializeObject<List<Wallet>>(StringListWallets);
                foreach (Wallet walet in UsersWalletList)
                {
                    Console.WriteLine(walet);
                }
                return UsersWalletList;
            }
            else
            {
                return null;
            }
        }

    }
}
