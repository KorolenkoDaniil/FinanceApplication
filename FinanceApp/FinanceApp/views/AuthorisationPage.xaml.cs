using FinanceApp.classes.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthorisationPage : ContentPage
    {
        public AuthorisationPage()
        {
            InitializeComponent();
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            User user = await UserRepository.AuthoriseUser(entryEmail.Text, entryPaasword.Text);
            if (user != null)
            {
                await Navigation.PushAsync(new ListPage());
            }
            else
            {
                button.Text = "пользователь не найден";
            }
           
        }
    }
}