using FinanceApp.classes.User;
using System;
using Xamarin.Forms;


namespace FinanceApp.views
{
    public partial class ListPage : ContentPage
	{
        User user = new User();

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
            MonthLabel.Text = DateTime.Now.ToString("MMMM yyyy");
            NavigationPage.SetHasNavigationBar(this, false);

        }
        public ListPage(User person)
        {
            InitializeComponent();
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list1.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            //arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            //arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
            user = person;
        }
        public ListPage(DateTime dateTime, bool MonthPeriod)
        {
            InitializeComponent();
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list1.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
            //arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            //arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
            MonthLabel.Text = dateTime.ToString("MMM yyyy");
        }


        private async void ToCalculatorPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatorPage());
        }

        private async void ToCAccountsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage());
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