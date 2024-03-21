using FinanceApp.classes;
using FinanceApp.classes.Users;
using FinanceApp.classes.Wallets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;


namespace FinanceApp.views
{
    public partial class ListPage : ContentPage, INotifyPropertyChanged
    {
        Context context;

        public ListPage(Context context)
        {
            Console.WriteLine("2 !!!!!!!!!!!!!!");

            InitializeComponent();
            this.context = context;
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list1.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            NavigationPage.SetHasNavigationBar(this, false);
            InitialiseWalltList();
            BindingContext = this;

        }

        public Color BackgroundColor
        {
            get => Color.FromHex(context.Color.LightText);
        }
    





        public async void InitialiseWalltList() {
            Console.WriteLine("3!!!!");
            context.SetWalletsCollection(await WalletRepository.GetWallets(context.User.Id));
        }



        public ListPage(DateTime dateTime, bool MonthPeriod)
        {
            InitializeComponent();
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list1.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            MonthLabel.Text = dateTime.ToString("MMM yyyy");
        }


        private async void ToCalculatorPage(object sender, EventArgs e) =>
            await Navigation.PushAsync(new CalculatorPage(context));


        private async void ToCAccountsPage(object sender, EventArgs e) =>
            await Navigation.PushAsync(new AccountsPage(context));
        

        private async void ToMonthSelectionPage(object sender, EventArgs e) =>
            await Navigation.PushAsync(new MonthSelectionPage()); 

        private async void AddOperation(object sender, EventArgs e) =>
            await Navigation.PushAsync(new AddOperationPage());        

    }
}