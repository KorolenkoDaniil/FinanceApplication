using FinanceApp.classes;
using FinanceApp.classes.Color;
using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public int theme = 2;
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
            Console.WriteLine("точка 1");
            if (string.IsNullOrEmpty(entryPass1.Text) || string.IsNullOrEmpty(entryPass2.Text) || string.IsNullOrEmpty(entryName.Text) || string.IsNullOrEmpty(entryEmail.Text))
            {
                Clean();
                return;
            }
            if (!string.Equals(entryPass1.Text, entryPass2.Text)) { Clean(); return; }


            Console.WriteLine("точка 2");
            context.ChangeUser(await UserRepository.SaveUser(new User(entryName.Text, entryEmail.Text, entryPass1.Text, theme)));
            context.ChangeTheme(await ColorRepository.GetColor(1));

            Console.WriteLine(context.Color);
            Console.WriteLine(context.User);


            Console.WriteLine("точка 3");
            if (context.User != null)
            {
                int id = context.User.Id;   
                Wallet wallet1 = new Wallet("кошелек 1", 0, context.User.Id, "денежные средства", context.User.Id % 20, true);
                Wallet wallet2 = new Wallet("кошелек 2", 0, context.User.Id, "сберегательный счет", context.User.Id % 10, true);

                var saveWallet1Task = WalletRepository.SaveWallet(wallet1);
                var saveWallet2Task = WalletRepository.SaveWallet(wallet2);

               
                await Task.WhenAll(saveWallet1Task, saveWallet2Task);


                bool w1 = await saveWallet1Task;
                Console.WriteLine(w1);

                bool w2 = await saveWallet2Task;
                Console.WriteLine("точка 8");
                Console.WriteLine(w2);

                if (w1 && w2)
                {
                    await Navigation.PushAsync(new ListPage(context));
                    Console.WriteLine("точка 9");
                }
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
