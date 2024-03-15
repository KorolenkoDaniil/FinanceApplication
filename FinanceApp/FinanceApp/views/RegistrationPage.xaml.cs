using FinanceApp.classes;
using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public string theme = "мятная тема";
        Context context;

        public RegistrationPage(Context context)
        {
            InitializeComponent(); 
            BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, false);
            this.context = context;
        }
   

        private async void ToPageOfCommonInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryPass1.Text) || string.IsNullOrEmpty(entryPass2.Text) || string.IsNullOrEmpty(entryName.Text) || string.IsNullOrEmpty(entryEmail.Text))
            {
                Clean();
                return;
            }
            if (!string.Equals(entryPass1.Text, entryPass2.Text)) { Clean(); return; }

           
            context.User = await UserRepository.SaveUser(new User(entryName.Text, entryEmail.Text, entryPass1.Text, theme));


            
            if (context.User != null)
            {
                Wallet wallet1 = new Wallet("кошелек 1", 0, context.User.Id);
                Wallet wallet2 = new Wallet("кошелек 2", 0, context.User.Id);
                bool w1 = await WalletRepository.SaveWallet(wallet1, context);
                bool w2 = await WalletRepository.SaveWallet(wallet2, context);


                if (w1 && w2) await Navigation.PushAsync(new ListPage(context));
                else Clean();
            }
            else Clean();
            //File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AccessFile"), $"{entryEmail.Text} {entryPass1.Text}");
        }

        private void Clean()
        {
            entryPass1.Text = "";
            entryPass2.Text = "";
            entryEmail.Text = "";
            entryName.Text = "";
            entryPass1.Placeholder = "enter pasword";
            entryPass2.Placeholder = "repeat pasword";
            entryEmail.Placeholder = "enter your email";
            entryName.Placeholder = "enter nickname";
        }
    }
}
