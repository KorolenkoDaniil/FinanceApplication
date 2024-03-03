using FinanceApp.classes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinanceApp.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MonthSelectionPage : ContentPage
	{
        public DateTime CurrentDate = DateTime.Now;
		public MonthSelectionPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            MonthLabel.Text = DateTime.Now.ToString("MMMM yyyy");
            LabelYear.Text = DateTime.Now.ToString("yyyy");
            arrow_L.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_l.png");
            arrow_R.Source = ImageSource.FromResource("FinanceApp.icons.arrow_to_r.png");

            DateTime month = new DateTime(DateTime.Now.Year, 1, 1);

            m1.Text = month.ToString("MMM");
            m2.Text = month.AddMonths(1).ToString("MMM");
            m3.Text = month.AddMonths(2).ToString("MMM");
            m4.Text = month.AddMonths(3).ToString("MMM");
            m5.Text = month.AddMonths(4).ToString("MMM");
            m6.Text = month.AddMonths(5).ToString("MMM");
            m7.Text = month.AddMonths(6).ToString("MMM");
            m8.Text = month.AddMonths(7).ToString("MMM");
            m9.Text = month.AddMonths(8).ToString("MMM");
            m10.Text = month.AddMonths(9).ToString("MMM");
            m11.Text = month.AddMonths(10).ToString("MMM");
            m12.Text = month.AddMonths(11).ToString("MMM");
        }

        private void PreviousYear(object sender, EventArgs e)
        {
            int DateInLabel = int.Parse(LabelYear.Text);
            DateInLabel--;

            //if (DateInLabel.Day == 1)
            //{
            //    DateInLabel = new DateTime(DateInLabel.Year, DateInLabel.Month, 1).AddDays(-1);
            //}
            LabelYear.Text = DateInLabel.ToString();
            MonthLabel.Text = MonthLabel.Text = CurrentDate.AddYears(-1).ToString("MMM yyyy");
            CurrentDate = CurrentDate.AddYears(-1);
        }

        private void NextYear(object sender, EventArgs e)
        {
            int DateInLabel = int.Parse(LabelYear.Text);
            DateInLabel++;

            //if (DateInLabel.Day == 1)
            //{
            //    DateInLabel = new DateTime(DateInLabel.Year, DateInLabel.Month, 1).AddDays(-1);
            //}
            LabelYear.Text = DateInLabel.ToString();
            MonthLabel.Text = MonthLabel.Text = CurrentDate.AddYears(1).ToString("MMM yyyy");
            CurrentDate = CurrentDate.AddYears(1);

        }

       


        private void NewMonth(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                m1.TextColor = Color.Black;
                m2.TextColor = Color.Black;
                m3.TextColor = Color.Black;
                m4.TextColor = Color.Black;
                m5.TextColor = Color.Black;
                m6.TextColor = Color.Black;
                m7.TextColor = Color.Black;
                m8.TextColor = Color.Black;
                m9.TextColor = Color.Black;
                m10.TextColor = Color.Black;
                m11.TextColor = Color.Black;
                m12.TextColor = Color.Black;
                button.TextColor = Color.Red;

                CurrentDate = DateConverter.Converter(button.Text);
                MonthLabel.Text = CurrentDate.ToString("MMM yyyy");
            }
        }
       

        private async void ToListPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage(CurrentDate));
        }
    }
}