using FinanceApp.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
			arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
			arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
            DateLabel.Text = DateTime.Now.ToString("dd MMMM");
            MonthLabel.Text = DateTime.Now.ToString("MMMM");
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
            arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
            user = person;
        }


        private async void ToCalculatorPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CalculatorPage());
        }

        private async void ToCAccountsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage());
        }
    }
}