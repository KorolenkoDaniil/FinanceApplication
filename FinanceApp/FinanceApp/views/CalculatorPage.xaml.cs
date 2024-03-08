using FinanceApp.classes.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FinanceApp.views
{
    public partial class CalculatorPage : ContentPage
    {
        User user;
        public CalculatorPage(User user)
        {
            InitializeComponent(); 
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png"); 
            list.Source = ImageSource.FromResource("FinanceApp.icons.list.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change1.png");
            delete.Source = ImageSource.FromResource("FinanceApp.icons.delete-right.png");
            this.user = user;
        }
        

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage());
        }

        private void ToCalcuatorPage(object sender, EventArgs e)
        {
            //сброс данных 
        }

        private async void ToConvertPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CovertPage(user));
        }

        private async void ToAccountsPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage(user));
        }
    }
}
