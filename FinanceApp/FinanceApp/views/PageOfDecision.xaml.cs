using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinanceApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageOfDecision : ContentPage
	{
		public PageOfDecision ()
		{
			InitializeComponent ();
			Logo.Source = ImageSource.FromResource("FinanceApp.icons.Money.png");
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}