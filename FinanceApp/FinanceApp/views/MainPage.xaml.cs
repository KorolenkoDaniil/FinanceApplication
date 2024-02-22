using FinanceApp.views;
using System;
using Xamarin.Forms;
using FinanceApp.classes;

namespace FinanceApp
{
    public partial class MainPage : ContentPage
    {
        public string color = "#FFF7EC";
        User user = new User();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
   

        private void PrintSize(object sender, EventArgs e)
        {
            double width = Application.Current.MainPage.Width;
            double height = Application.Current.MainPage.Height;
            Console.WriteLine(width);
            Console.WriteLine(height);
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!");
        }

        private async void ToPageOfCommonInformation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entryPass1.Text) || string.IsNullOrEmpty(entryPass2.Text) || string.IsNullOrEmpty(entryName.Text) || string.IsNullOrEmpty(entryEmail.Text)) return;
           
            if (!string.Equals(entryPass1.Text, entryPass2.Text)) return;

            User newuser = new User(entryName.Text, entryEmail.Text, entryPass1.Text);
            user = newuser;
            await Navigation.PushAsync(new ListPage());
        }
    }
}
