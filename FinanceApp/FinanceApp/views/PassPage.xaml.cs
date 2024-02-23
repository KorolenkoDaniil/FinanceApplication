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
        string passCode = "";
        public PassPage()
        {
            InitializeComponent();
            delete.Source = ImageSource.FromResource("FinanceApp.icons.delete-right.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void NumberButtonClicked(object sender, EventArgs e)
        {
            if (passCode.Length > 3) return;
            if (sender is Button button)
            {
                passCode += button.Text;
            }
            Console.WriteLine(passCode);
            ColorizeCircle();
        }


        public void DeleteSymbol(object sender, EventArgs e)
        {
            if (passCode.Length <= 0) return;
            passCode = passCode.Substring(0, passCode.Length - 1);
            Console.WriteLine(passCode);
            DeColorizeCircle();
        }
        public void DeleteSymbol()
        {
            if (passCode.Length <= 0) return;
            passCode = passCode.Substring(0, passCode.Length - 1);
            Console.WriteLine(passCode);
            DeColorizeCircle();
        }



        public async void ColorizeCircle()
        {
            int circlenumber = passCode.Length;
            switch (circlenumber)
            {
                case 1:
                    {
                        circle1.BackgroundColor = Color.Black;
                        break;
                    }
                case 2:
                    {
                        circle2.BackgroundColor = Color.Black;
                        break;
                    }
                case 3:
                    {
                        circle3.BackgroundColor = Color.Black;
                        break;
                    }
                case 4:
                    {
                        circle4.BackgroundColor = Color.Black;
                        if (string.Equals("1234", passCode)) await Navigation.PushAsync(new ListPage());
                        else
                        {
                            DeleteSymbol();
                            DeleteSymbol();
                            DeleteSymbol();
                            DeleteSymbol();
                        }
                        break;
                    }

            }
        }



        public void DeColorizeCircle()
        {
            int circlenumber = passCode.Length;
            switch (circlenumber)
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