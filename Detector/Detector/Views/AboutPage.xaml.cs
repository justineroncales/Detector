using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.GoogleMaps;
using Detector.Maps;
using System.Collections.Generic;
using Plugin.Geolocator;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Detector.Models;
using Detector.Services;

namespace Detector.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            SetLocations();
        }
        public async void SetLocations()
        {
            List<CustomPin> customPins = new List<CustomPin>
            {
                new CustomPin("Nasugbu",1,14.0940, 120.6890),
                new CustomPin("Brgy AGA",2,14.0924689,120.7690493),
                new CustomPin("Brgy Balaytigui",3,14.0747,120.8172),
                new CustomPin("Brgy  Banilad",4,14.0730,120.7408),
                new CustomPin("Brgy  Barangay 1",5,14.0752,120.6296),
                new CustomPin("Brgy  Barangay 1",6,14.0752,120.6296),
                new CustomPin("Brgy  Barangay 11",7,14.0604,120.6344),
                new CustomPin("Brgy  Barangay 12",8,14.0639,120.6358),
                new CustomPin("Brgy  Barangay 2",9,14.0783,120.6300),
                new CustomPin("Brgy  Barangay 3",10,14.0724,120.6307),
                new CustomPin("Brgy  Barangay 4",11,14.0735,120.6340),
                new CustomPin("Brgy  Barangay 5",12,14.0756,120.6343),
                new CustomPin("Brgy  Barangay 6",13,14.0684,120.6374),
                new CustomPin("Brgy  Barangay 7",14,14.0694,120.6351),
                new CustomPin("Brgy  Barangay 8",15,14.0694,120.6351),
                new CustomPin("Brgy  Barangay 9",16,14.0695,120.6324),
                new CustomPin("Brgy  Bilaran",17,14.0487,120.6846),
                new CustomPin("Brgy  Bucana",18,14.0678, 120.6267),
                new CustomPin("Brgy  Bulihan",19,14.1552, 120.6540),
                new CustomPin("Brgy  Bunducan",20,14.1069, 120.6521),
                new CustomPin("Brgy  Butucan",21,14.1394, 120.6805),
                new CustomPin("Brgy  Calayo",22,14.1461, 120.6141),
                new CustomPin("Brgy  Catandaan",23,14.0804, 120.6815),
                new CustomPin("Brgy  Cogunan",24,14.0625, 120.6555),
                new CustomPin("Brgy  Dayap",25,14.1013, 120.6627),
                new CustomPin("Brgy  Kaylaway",26,14.0747, 120.8172),
                new CustomPin("Brgy  Kayrilaw",27,14.1027, 120.7819),
                new CustomPin("Brgy  Latag",28,14.1164, 120.7124),
                new CustomPin("Brgy  Looc",29,114.1641, 120.6295),
                new CustomPin("Brgy  Lumbangan",30,14.0494, 120.6597),
                new CustomPin("Brgy  Malapad na Bato",31,14.1116, 120.6828),
                new CustomPin("Brgy  Mataas na Pulo",32,14.1122, 120.7452),
                new CustomPin("Brgy  Maugat",33,114.0868, 120.6767),
                new CustomPin("Brgy  Munting Indan",34,14.1031, 120.6985),
                new CustomPin("Brgy  Natipuan",35,14.1198, 120.6236),
                new CustomPin("Brgy  Pantalan",36,114.0907, 120.6323),
                new CustomPin("Brgy  Papaya",37,14.1919, 120.6096),
                new CustomPin("Brgy  Putat",38,14.0788, 120.6527),
                new CustomPin("Brgy  Reparo",39,14.0728, 120.6923),
                new CustomPin("Brgy  Talangan",40,14.0777, 120.6358),
                new CustomPin("Brgy  Tumalim",41,14.0786, 120.7224),
                new CustomPin("Brgy  Utod",42,14.1195, 120.6479),
                new CustomPin("Brgy  Wawa",43,14.0824, 120.6244),










            };

            foreach (var item in customPins)
            {
                var _status =await GetLocations(item.id);

                if (_status == "high")
                {
                    var pin = new Pin
                    {
                        Type = PinType.Place,
                        Label = "Heavy Rains",
                        Icon = BitmapDescriptorFactory.FromBundle("heavy"),
                        Position = (new Position(item.Latitude, item.Longitude)),
                        Address = item.Name

                    };
                    map.Pins.Add(pin);
                }
                else if (_status == "low")
                {
                    var pin = new Pin
                    {
                        Type = PinType.Place,
                        Label = "Moderate",
                        Icon = BitmapDescriptorFactory.FromBundle("umbrella"),
                        Position = (new Position(item.Latitude, item.Longitude)),
                        Address = item.Name

                    };
                    map.Pins.Add(pin);
                }
                else
                {
                    var pin = new Pin
                    {
                        Type = PinType.Place,
                        Label = "Normal",
                        Icon = BitmapDescriptorFactory.FromBundle("sun"),
                        Position = (new Position(item.Latitude, item.Longitude)),
                        Address = item.Name

                    };
                    map.Pins.Add(pin);
                }
            }

            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),
                                                         Distance.FromMiles(1)));
        }
        public async Task<string> GetLocations(int ID)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync("http://www.waterdetector.somee.com/Mobile/GetLocations?ID=" + ID);
                if (result.IsSuccessStatusCode)
                {
                    string res = await result.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<string>(res);
                }
            }
            return response;
        }

    }
}