using FinanceApp.classes;
using FinanceApp.classes.Color;
using FinanceApp.classes.Users;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorisationPage : ContentPage
    {
        Context context;
        public AuthorisationPage(Context context)
        {
            InitializeComponent();
            this.context = context;
            Loading.IsVisible = false;
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            button.IsEnabled = false; 
            Loading.IsVisible = true;

            context.ChangeUser(await UserRepository.AuthoriseUser(entryEmail.Text, entryPaasword.Text));
            //context.ChangeTheme(await ColorRepository.GetColor());
            context.ChangeTheme(await ColorRepository.GetColor(1));
            Console.WriteLine(context.Color);


            if (context.User != null)
            {
                Console.WriteLine("1 !!!!!!!!!!!!!!");
                await Navigation.PushAsync(new ListPage(context));
            }
            else
            {
                button.Text = "пользователь не найден";
            }

            Loading.IsVisible = false;

           
            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                button.IsEnabled = true;
                return false; 
            });
        }

    }
}