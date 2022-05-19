using Detector.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Detector.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            bool un = string.IsNullOrEmpty(Username.Text);
            bool pw = string.IsNullOrEmpty(Password.Text);
            bool fn = string.IsNullOrEmpty(FName.Text);
            bool ln = string.IsNullOrEmpty(LName.Text);
            bool em = string.IsNullOrEmpty(Email.Text);
            bool cp = string.IsNullOrEmpty(CPassword.Text);

            if (un && pw && fn && ln && em && cp)
            {
                await DisplayAlert("Opps", "Pls fill the following fields", "ok");
            }
            else
            {
                if (Password.Text == CPassword.Text)
                {
                    UsersDetails users = new UsersDetails
                    {
                        FIRSTNAME = FName.Text,
                        LASTNAME = LName.Text,
                        USERNAME = Username.Text,
                        PASSWORD = Password.Text,
                        EMAIL = Email.Text
                    };

                    HttpClient httpClient = new HttpClient();
                    httpClient.BaseAddress = new Uri("http://www.waterdetector.somee.com"); // Insert your API URL Address here.
                    string serializedObject = JsonConvert.SerializeObject(users);
                    HttpContent contentPost = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                    try
                    {
                        var response = await httpClient.PostAsync("/Mobile/Create", contentPost);
                        if (response.IsSuccessStatusCode)
                        {
                            var tokenJson = await response.Content.ReadAsStringAsync();
                            if (tokenJson == "true")
                            {
                               var res =  await DisplayAlert("Success", "Go to Login Page", "Ok", "Cancel");
                                if (res)
                                {
                                    await Navigation.PushAsync(new LoginPage(), false);
                                }
                            }
                            else
                            {
                                await DisplayAlert("Opps", "Account is already existing", "ok");
                            }
                        }

                    }
                    catch (TaskCanceledException ex)
                    {
                        throw;
                    }
                    catch (Exception ex)
                    {
                        ex.Message.ToString();
                    }
                }
                else
                {
                    await DisplayAlert("Opps", "Password Mismatch", "ok");
                }
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage(), false);
        }
    }
}