using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassPage : ContentPage
    {
        char[] passCode = new char[4];
        int passCodeIndex = -1;
        public PassPage()
        {
            InitializeComponent();
            delete.Source = ImageSource.FromResource("FinanceApp.icons.delete-right.png");
        }

        private void NumberButtonClicked(object sender, EventArgs e)
        {
            if (passCodeIndex < 4) passCodeIndex++;
            if (sender is Button button)
            {
                passCode[passCodeIndex] = button.Text.ToCharArray()[0];
            }
            for (int i = 0; i < passCode.Length; i++) Console.WriteLine(passCode[i]);
            ColorizeCircle(passCodeIndex);
        }


        public void DeleteSymbol(object sender, EventArgs e)
        {
            if (passCodeIndex > -1) DeColorizeCircle(passCodeIndex);
        }



        public async void ColorizeCircle(int circleNumber)
        {
            switch (passCodeIndex)
            {
                case 0:
                    {
                        circle1.BackgroundColor = Color.Black;
                        break;
                    }
                case 1:
                    {
                        circle2.BackgroundColor = Color.Black;
                        break;
                    }
                case 2:
                    {
                        circle3.BackgroundColor = Color.Black;
                        break;
                    }
                case 3:
                    {
                        string code = "";
                        foreach (char num in passCode) code += num;
                        if (string.Equals("1234", code))
                        {
                            await Navigation.PushAsync(new ListPage());
                        }
                        else
                        {
                            DeColorizeCircle(3);
                            DeColorizeCircle(2);
                            DeColorizeCircle(1);
                            DeColorizeCircle(0);
                        }

                        break;
                    }

            }
        }



        public void DeColorizeCircle(int circleNumber)
        {
            passCode[passCodeIndex] = 'a';
            passCodeIndex--;
            switch (passCodeIndex)
            {
                case 0:
                    {
                        circle1.BackgroundColor = Color.FromHex("#FFF7EC");
                        break;
                    }
                case 1:
                    {
                        circle2.BackgroundColor = Color.FromHex("#FFF7EC");
                        break;
                    }
                case 2:
                    {
                        circle3.BackgroundColor = Color.FromHex("#FFF7EC");
                        break;
                    }
                case 3:
                    {
                        circle4.BackgroundColor = Color.FromHex("#FFF7EC");
                        break;
                    }

            }
        }

    }
}