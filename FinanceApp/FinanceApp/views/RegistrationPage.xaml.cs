using FinanceApp.classes.User;
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
        
        public RegistrationPage()
        {
            InitializeComponent(); 
            BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private void PrintSize(object sender, EventArgs e)
        {
            double width = Application.Current.MainPage.Width;
            double height = Application.Current.MainPage.Height;
            Console.WriteLine(width);
            Console.WriteLine(height);
        }


        //метод перехода на страницу общей информации
        private async void ToPageOfCommonInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryPass1.Text) || string.IsNullOrEmpty(entryPass2.Text) || string.IsNullOrEmpty(entryName.Text) || string.IsNullOrEmpty(entryEmail.Text))
            {
                Clean();
                return;
            }
            if (!string.Equals(entryPass1.Text, entryPass2.Text)) { Clean(); return; }

            User newuser = new User(entryName.Text, entryEmail.Text, entryPass1.Text, theme);
            bool result = await UserRepository.SaveUser(newuser);
            if (result) await Navigation.PushAsync(new ListPage());
            else
            {
                Clean();
            }
            //File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AccessFile"), $"{entryEmail.Text} {entryPass1.Text}");
        }

        private void Clean()
        {
            entryPass1.Text = "";
            entryPass2.Text = "";
            entryEmail.Text = "";
            entryName.Text = "";
            entryPass1.Placeholder = "enter pasword";
            entryPass2.Text = "repeat pasword";
            entryEmail.Text = "enter your email";
            entryName.Text = "enter nickname";

        }
    }
}
