using FinanceApp.classes;
using FinanceApp.views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FinanceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            Logo.Source = ImageSource.FromResource("FinanceApp.icons.Money.png");
            NavigationPage.SetHasNavigationBar(this, false); 
            ToPassPage();
        }
        public async void ToPassPage()
        {
            if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AccessFile")))
            {
                await Navigation.PushAsync(new PassPage());
            }
        }

        private async void ToSignUpPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }

        private async void ToSignInPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthorisationPage());
        }
    }
}
