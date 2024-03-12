using FinanceApp.classes.User;
using FinanceApp.classes.Wallet;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public string theme = "мятная тема";
        
        public RegistrationPage()
        {
            InitializeComponent(); 
            BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void PrintSize(object sender, EventArgs e)
        {
            double width = Application.Current.MainPage.Width;
            double height = Application.Current.MainPage.Height;
            Console.WriteLine(width);
            Console.WriteLine(height);
        }


        private async void ToPageOfCommonInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryPass1.Text) || string.IsNullOrEmpty(entryPass2.Text) || string.IsNullOrEmpty(entryName.Text) || string.IsNullOrEmpty(entryEmail.Text))
            {
                Clean();
                return;
            }
            if (!string.Equals(entryPass1.Text, entryPass2.Text)) { Clean(); return; }

            User newuser = new User(entryName.Text, entryEmail.Text, entryPass1.Text, theme);
            newuser = await UserRepository.SaveUser(newuser);

            
            if (newuser != null)
            {
                Wallet wallet1 = new Wallet("кошелек 1", 0, newuser.Id, "денежные средства", 1, 1, true);
                Wallet wallet2 = new Wallet("кошелек 2", 0, newuser.Id, "сберегательный счет", 1, 1, true);
                bool w1 = await WalletRepository.SaveWallet(wallet1);
                bool w2 = await WalletRepository.SaveWallet(wallet2);

                if (w1 && w2)
                    await Navigation.PushAsync(new ListPage());
                else Clean();
            }
            else
            {
                Clean();
            }
            //File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AccessFile"), $"{entryEmail.Text} {entryPass1.Text}");
        }

        private void Clean()
        {
            entryPass1.Text = "";
            entryPass2.Text = "";
            entryEmail.Text = "";
            entryName.Text = "";
            entryPass1.Placeholder = "enter password";
            entryPass2.Placeholder = "repeat password";
            entryEmail.Placeholder = "enter your email";
            entryName.Placeholder = "enter nickname";
        }
    }
}
