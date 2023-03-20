using Detector.Models;
using Newtonsoft.Json;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RestSharp;

namespace Detector.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportPage : ContentPage
    {
        string _userName;
        public ReportPage(string userName)
        {
            InitializeComponent();
            _userName = userName;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            bool ismessage = string.IsNullOrEmpty(Message.Text);
            if (ismessage)
            {
                await DisplayAlert("Opps", "Pls fill the following fields", "ok");
            }
            else
            {
                var locator = CrossGeolocator.Current;
                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
                UsersDetails users = new UsersDetails()
                {
                    MESSAGE = Message.Text,
                    USERNAME = _userName,
                    LATITUDE = position.Latitude,
                    LONGITUDE = position.Longitude,
                    ID = _userName
                };
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("http://www.waterdetector.somee.com"); // Insert your API URL Address here.
                string serializedObject = JsonConvert.SerializeObject(users);
                HttpContent contentPost = new StringContent(serializedObject, Encoding.UTF8, "application/json");
                try
                {
                    var response = await httpClient.PostAsync("/Mobile/SendReport", contentPost);
                    if (response.IsSuccessStatusCode)
                    {
                        await DisplayAlert("Success", "Report successfull sent", "ok");

                        Data data = new Data
                        {
                            recipient = "09562447811",
                            message = Message.Text
                        };
                        Sendnotification(data);
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
        }
        private void Sendnotification(Data data)
        {
            string serializedObject = JsonConvert.SerializeObject(data);
            var client = new RestSharp.RestClient("https://api.sms.fortres.net/v1/messages");
            var request = new RestRequest("https://api.sms.fortres.net/v1/messages", Method.Post);
            request.AddHeader("Authorization", "Basic NTFhYzRiM2ItMjJhMC00Y2Y4LWFiN2UtNzUwZWQ5MTE2NDMzOlNTWURKZDZIdFU1Q1RpZ3A1cGdseFJLSTRlclhaVk9kSDlKc2R0MXU=");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", serializedObject, ParameterType.RequestBody);
            var response = client.Execute(request);
        }
    }
}