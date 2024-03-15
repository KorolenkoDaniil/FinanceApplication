using FinanceApp.classes;
using FinanceApp.classes.Users;
using System;
using Xamarin.Forms;
namespace FinanceApp.views
{
    public partial class CalculatorPage : ContentPage
    {
        Context context;
        public CalculatorPage(Context context)
        {
            InitializeComponent(); 
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png"); 
            list.Source = ImageSource.FromResource("FinanceApp.icons.list.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change1.png");
            delete.Source = ImageSource.FromResource("FinanceApp.icons.delete-right.png");
            this.context = context;
        }
        

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage(context));
        }

        private void ToCalcuatorPage(object sender, EventArgs e)
        {
            //сброс данных 
        }

        private async void ToConvertPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CovertPage(context));
        }

        private async void ToAccountsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage(context));
        }
    }
}
