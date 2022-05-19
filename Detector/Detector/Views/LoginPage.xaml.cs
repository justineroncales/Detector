using Detector.Services;
using Detector.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Android.Provider.SyncStateContract;

namespace Detector.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool un = string.IsNullOrEmpty(UserName.Text);
            bool pw = string.IsNullOrEmpty(Password.Text);

            if (!un && !pw)
            {
                UsersDetails users = new UsersDetails()
                {
                    USERNAME = UserName.Text,
                    PASSWORD = Password.Text
                };

                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("http://www.waterdetector.somee.com"); // Insert your API URL Address here.
                string serializedObject = JsonConvert.SerializeObject(users);
                HttpContent contentPost = new StringContent(serializedObject, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync("/Mobile/Login", contentPost);
                    if (response.IsSuccessStatusCode)
                    {
                        var tokenJson = await response.Content.ReadAsStringAsync();
                        string userid = JsonConvert.DeserializeObject<string>(tokenJson);
                        if (userid != "0")
                        {
                            await Navigation.PushAsync(new NavPages(userid), false);
                        }
                        else
                        {
                            await DisplayAlert("Opps", "Incorrect username or password", "ok");
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                await DisplayAlert("Opps", "Pls fill the following fields", "ok");
            }

        }
        private async void SignUpClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register(), false);
        }
    }
}