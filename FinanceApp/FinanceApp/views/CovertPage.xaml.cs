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
    public partial class CovertPage : ContentPage
    {
        public CovertPage()
        {
            InitializeComponent();
        }

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CommonInformationPage());
        }
    }
}