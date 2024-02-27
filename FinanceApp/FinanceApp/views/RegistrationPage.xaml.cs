using FinanceApp.classes;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace FinanceApp.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public string theme = "#FFF7EC";
        User user = new User();
        public RegistrationPage()
        {
            InitializeComponent(); 
            BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void PrintSize(object sender, EventArgs e)
        {
            double width = Application.Current.MainPage.Width;
            double height = Application.Current.MainPage.Height; Console.WriteLine(width);
            Console.WriteLine(height);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!");
        }
        private async void ToPageOfCommonInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryPass1.Text) || string.IsNullOrEmpty(entryPass2.Text) || string.IsNullOrEmpty(entryName.Text) || string.IsNullOrEmpty(entryEmail.Text)) return;
            if (!string.Equals(entryPass1.Text, entryPass2.Text)) return;

            User newuser = new User(entryName.Text, entryEmail.Text, entryPass1.Text, theme); 
            user = newuser;
            await Navigation.PushAsync(new ListPage());
            //File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AccessFile"), $"{entryEmail.Text} {entryPass1.Text}");
        }
    }
}
