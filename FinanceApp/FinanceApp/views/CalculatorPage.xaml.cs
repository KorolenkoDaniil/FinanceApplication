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
	public partial class CalculatorPage : ContentPage
	{
		public CalculatorPage ()
		{
			InitializeComponent ();
            card.Source = ImageSource.FromResource("FinanceApp.icons.card.png");
            cathegory.Source = ImageSource.FromResource("FinanceApp.icons.cathegories.png");
            list.Source = ImageSource.FromResource("FinanceApp.icons.list.png");
            diagram.Source = ImageSource.FromResource("FinanceApp.icons.diagram.png");
            change.Source = ImageSource.FromResource("FinanceApp.icons.change1.png");
            delete.Source = ImageSource.FromResource("FinanceApp.icons.delete-right.png");
        }

        private void change_Clicked(object sender, EventArgs e)
        {

        }
    }
}