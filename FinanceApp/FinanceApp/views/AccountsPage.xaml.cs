using FinanceApp.classes.User;
using FinanceApp.classes.Wallet;
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
    public partial class AccountsPage : ContentPage
    {
        User user;
        Decimal sum = 0;
        public AccountsPage(User user)
        {
            InitializeComponent();
            card.Source = ImageSource.FromResource("FinanceApp.icons.card1.1.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            arrow_to_left.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            NavigationPage.SetHasNavigationBar(this, false);
            this.user = user;
            ShowWallets();
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }

        private async void change_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatorPage(user));
        }

        private async void ShowWallets()
        {
            List<Wallet> WalletList = await WalletRepository.GetWallets(user.Id);
            foreach (Wallet wallet in WalletList)
            {
                sum += wallet.Amount;
                Console.WriteLine(wallet);
            }
            Sum.Text = $"$ {sum}";
            WalletsCollection.ItemsSource = WalletList;
        }

        private void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Clicked(object sender, EventArgs e)
        {

        }
    }
}