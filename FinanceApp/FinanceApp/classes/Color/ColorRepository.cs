using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp.classes.Color
{
    internal class ColorRepository
    {
        private static readonly HttpClient client = new HttpClient();
        public async static Task<ColorClass> GetColor(int colorId)
        {
            Console.WriteLine(colorId.ToString() + "цвет");
            Dictionary<string, string> ColorId = new Dictionary<string, string>
            {
                {"id", colorId.ToString()}
            };

            FormUrlEncodedContent form = new FormUrlEncodedContent(ColorId);
            HttpResponseMessage response = await client.PostAsync(Links.GetColor, form);


            if (response.IsSuccessStatusCode)
            {
                string color = await response.Content.ReadAsStringAsync();
                ColorClass result = JsonConvert.DeserializeObject<ColorClass>(color);
                return result;
            }
            else
            {
                return null;
            }
        }

    }
}
