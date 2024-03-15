using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.classes.Wallets
{
    public static class WalletRepository
    {
        private static readonly HttpClient client = new HttpClient();

        static WalletRepository() { }
        public async static Task<bool> SaveWallet(Wallet newWallet, Context context)
        {
            string json = JsonConvert.SerializeObject(newWallet);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(Links.SaveWallet, content);

            if (response.IsSuccessStatusCode)
            {
                context.Wallets.Add(newWallet);
                return true;
            }
            else return false;
        }


        public async static Task<List<Wallet>> GetWallets(int userId)
        {
          
            Dictionary<string, string> UserId = new Dictionary<string, string>
            {
                {"id", userId.ToString()}
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(UserId);
            HttpResponseMessage response = await client.PostAsync(Links.GetWallets, form);


            if (response.IsSuccessStatusCode)
            {
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
