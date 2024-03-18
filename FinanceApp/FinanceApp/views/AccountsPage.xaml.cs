using FinanceApp.classes;
using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        int c = 0;
        
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
            ColorsPage.IsVisible = false;


            WalletIcon.BackgroundColor = Color.FromHex(Colors.colors[context.User.Id % 30]); 
            ShowWallets();
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage(context));
        }

        private async void change_Clicked(object sender, EventArgs e) =>
            await Navigation.PushAsync(new CalculatorPage(context));
        

        private async void ShowWallets()
        {
            List<Wallet> wallets = await WalletRepository.GetWallets(context.User.Id);
            foreach (Wallet wallet in wallets)
            {
                sum += wallet.Amount;
                Console.WriteLine(wallet);
            }
            Sum.Text = $"$ {sum}";
            WalletsCollection.ItemsSource = context.Wallets;
        }

        private void ToColorsPage(object sender, EventArgs e)
        {
            if (sender is Button button1) button1.IsEnabled = false; 
            WalletsPage.IsVisible = false;
            NewWalletsPage.IsVisible = false;
            ColorsPage.IsVisible = true;
            Add.IsVisible = false;

            var grid = new Grid();


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
                        TextColor = Color.Transparent,

                    };
                    ColorButton.Clicked += (sender1, e1) => {
                       
                        SaveColor((Button)sender1);
                    };
                    grid.Children.Add(ColorButton, i, j);
                    k++;
                }
            }

            ColorFrame.Content = grid;
            if (sender is Button button2) button2.IsEnabled = true;

        }

        private void SaveColor(object sender)
        {
            if (sender is Button colorButton)
            {
                WalletIcon.BackgroundColor = Color.FromHex(Colors.colors[int.Parse(colorButton.Text)]);
                c = int.Parse(colorButton.Text);
                WalletsPage.IsVisible = false;
                NewWalletsPage.IsVisible = true;
                ColorsPage.IsVisible = false;
                Add.IsVisible = false;

            }
            else return;
        }



        private void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            WalletsPage.IsVisible = false;
            NewWalletsPage.IsVisible = true;
            ColorsPage.IsVisible = false;
            Add.IsVisible = false;

        }

        private async void SaveButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text)) { name.PlaceholderColor = Color.Red; return; }
            else name.PlaceholderColor = Color.FromHex("#a2a4a6");
            if (string.IsNullOrEmpty(balance.Text)) { name.PlaceholderColor = Color.Red; return; }
            else name.PlaceholderColor = Color.FromHex("#a2a4a6");



            int id = context.User.Id;
            Wallet wallet = new Wallet(name.Text, decimal.Parse(balance.Text), id, TypePicker.SelectedIndex.ToString(), c, checkBox.IsChecked);
            await WalletRepository.SaveWallet(wallet);
            WalletsPage.IsVisible = true;
            NewWalletsPage.IsVisible = false;
            ColorsPage.IsVisible = false;
            Add.IsVisible = true;
            ShowWallets();
        }

        private void CancelButton(object sender, EventArgs e)
        {
            WalletsPage.IsVisible = true;
            NewWalletsPage.IsVisible = false;
            ColorsPage.IsVisible = false;
            Add.IsVisible = true;
        }
    }
}