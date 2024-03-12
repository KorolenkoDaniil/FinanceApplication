﻿using FinanceApp.classes;
using FinanceApp.classes.User;
using FinanceApp.classes.Wallet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;


namespace FinanceApp.views
{
    public partial class ListPage : ContentPage, INotifyPropertyChanged
    {
        User user = new User();
        List<Wallet> WalletsList = new List<Wallet>();
        public Color theme;

		public ListPage ()
		{
			InitializeComponent ();

			card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list1.png");
			diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
			change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
			//arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
			//arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
   //         DateLabel.Text = DateTime.Now.ToString("dd MMMM");
           
          
            NavigationPage.SetHasNavigationBar(this, false);
           


        }
        public ListPage(User person)
        {
            Console.WriteLine("2 !!!!!!!!!!!!!!");

            InitializeComponent();
            InitialiseWalltList(person);
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list1.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            settings.Source = ImageSource.FromResource("FinanceApp.icons.settings.png");
            //arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            //arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
            NavigationPage.SetHasNavigationBar(this, false);
            MonthLabel.Text = DateTime.Now.ToString("MMMM yyyy");

            user = person;
            this.BindingContext = this;
            theme = Color.FromHex(Colors.myDictionary[person.Theme]);
            MonthLabel.BackgroundColor = theme;
            //Console.WriteLine(Color.FromHex(Colors.myDictionary[person.Theme])); 
            Console.WriteLine(Colors.myDictionary[person.Theme]);
        }

        public async void InitialiseWalltList(User person)
        {
            WalletsList = await WalletRepository.GetWallets(person.Id);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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


        private async void ToCalculatorPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatorPage(user));
        }

        private async void ToCAccountsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage(user));
        }

        private async void ToMonthSelectionPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MonthSelectionPage()); 
        }

        private async void AddOperation(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddOperationPage());
        }

        //private void PreviousDate(object sender, EventArgs e)
        //{
        //    DateTime DateInLabel = DateTime.Parse(DateLabel.Text);
        //    DateInLabel = DateInLabel.AddDays(-1);

        //    if (DateInLabel.Day == 1)
        //    {
        //        DateInLabel = new DateTime(DateInLabel.Year, DateInLabel.Month, 1).AddDays(-1);
        //    }
        //    DateLabel.Text = DateInLabel.ToString("dd MMMM");
        //}

        //private void NextDate(object sender, EventArgs e)
        //{
        //    DateTime DateInLabel = DateTime.Parse(DateLabel.Text);
        //    DateInLabel = DateInLabel.AddDays(1);

        //    if (DateInLabel.Day == 1)
        //    {
        //        DateInLabel = new DateTime(DateInLabel.Year, DateInLabel.Month, 1).AddMonths(1);
        //    }
        //    DateLabel.Text = DateInLabel.ToString("dd MMMM");
        //}




    }
}