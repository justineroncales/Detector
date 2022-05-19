using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Detector.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavPages : ContentPage
    {
        string _username;
        public NavPages(string userid)
        {
            InitializeComponent();
            _username = userid;
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage(), false);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WeatherPage(), false);
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportPage(_username), false);
        }
    }
}