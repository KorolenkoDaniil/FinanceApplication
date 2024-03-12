using FinanceApp.classes;
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
        decimal sum = 0;
        Wallet ChoosenWallet = new Wallet();

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
            NewCardPage.IsVisible = false;
            AllCardsPage.IsVisible = true;
            ColorLayout.IsVisible = false;
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
                if (wallet.IncludeOrNot)
                    sum += wallet.Amount;
                Console.WriteLine(wallet);
            }
            Sum.Text = $"$ {sum}";
            WalletsCollection.ItemsSource = WalletList;
        }

        private void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            //ChoosenWallet = e.CurrentSelection.FirstOrDefault() as Wallet;

            //if (ChoosenWallet != null)
            //{
               
            //}

            //itemCollection.SelectedItem = null;
        }

        private void newCardsPage(object sender, EventArgs e)
        {
            AllCardsPage.IsVisible = false;
            NewCardPage.IsVisible = true;
            ColorLayout.IsVisible = false;
        }

        private async void Reload(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage(user));
        }

     
        private void ToColorsPage(object sender, EventArgs e)
        {
            NewCardPage.IsVisible = false;
            AllCardsPage.IsVisible = false;
            ColorLayout.IsVisible = true;

            var grid = new Grid();

            // Добавляем 4 колонки
            for (int i = 0; i < 4; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            int k = 0;
            for (int j = 0; j < 17; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    Button ColorButton = new Button
                    {
                        BackgroundColor = Color.FromHex(Colors.colors[k]),
                        WidthRequest = 50,
                        HeightRequest = 50,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center,
                        CornerRadius = 30,
                        Text = k.ToString(),
                        //TextColor = Color.FromHex(Colors.colors[k]),
                        TextColor = Color.Transparent,

                    };
                    ColorButton.Clicked += SaveColor(ColorButton);
                    grid.Children.Add(ColorButton, i, j);
                    k++;
                }
            }

            ColorFrame.Content = grid;
        }

        private EventHandler SaveColor(object sender)
        {
            if (sender is Button button)
            {

            }
            throw new NotImplementedException();
        }


    }
}