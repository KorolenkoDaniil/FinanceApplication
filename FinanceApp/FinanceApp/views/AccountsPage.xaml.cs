using FinanceApp.classes;
using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
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
        Context context;
        Decimal sum = 0;
        public AccountsPage(Context context)
        {
            InitializeComponent();
            card.Source = ImageSource.FromResource("FinanceApp.icons.card1.1.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            arrow_to_left.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            NavigationPage.SetHasNavigationBar(this, false);
            this.context = context;
            WalletsPage.IsVisible = true;
            NewWalletsPage.IsVisible = false;
            ShowWallets();
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage(context));
        }

        private async void change_Clicked(object sender, EventArgs e) =>
            await Navigation.PushAsync(new CalculatorPage(context));
        

        private void ShowWallets()
        {
            
            foreach (Wallet wallet in context.Wallets)
            {
                sum += wallet.Amount;
                Console.WriteLine(wallet);
            }
            Sum.Text = $"$ {sum}";
            WalletsCollection.ItemsSource = context.Wallets;
        }

        private void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            WalletsPage.IsVisible = false;
            NewWalletsPage.IsVisible = true;
        }
    }
}