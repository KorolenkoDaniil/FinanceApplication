using FinanceApp.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace FinanceApp
{
    public partial class MainPage : ContentPage/*, INotifyPropertyChanged*/
    {
        public string color = "#FFF7EC";
        //public string Color
        //{
        //    get { return _color; }
        //    set
        //    {
        //        if (_color != value)
        //        {
        //            _color = value;
        //            OnPropertyChanged(nameof(Color));
        //        }
        //    }
        //}

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
            await Navigation.PushAsync(new ListPage());
        }

        //private async void ToPassPage(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Pas());
        //}
    }
}
