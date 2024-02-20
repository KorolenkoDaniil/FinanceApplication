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
	public partial class CommonInformationPage : ContentPage
	{
		public CommonInformationPage ()
		{
			InitializeComponent ();
			card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list.png");
			diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
			change.Source = ImageSource.FromResource("FinanceApp.icons.change.png");
			arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
			arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");
		}

        private async void ToCardPage(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new MainPage()); 
        }
    }
}