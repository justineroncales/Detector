using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
using Detector.Maps;
using System.Collections.Generic;
using Plugin.Geolocator;
using System.Threading.Tasks;

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

            Pin pin1 = new Pin
            {
                Label = "This is Nasugbu",
                Address = "Nasugbu",
                Type = PinType.Place,
                Position = new Position(14.0940, 120.6890)
            };
            Pin pin2 = new Pin
            {
                Label = "This is Aga",
                Address = "Brgy AGA",
                Type = PinType.Place,
                Position = new Position(14.0924689, 120.7690493)
            };
            Pin pin3 = new Pin
            {
                Label = "This is  Balaytigui",
                Address = "Brgy Balaytigui",
                Type = PinType.Place,
                Position = new Position(14.0747, 120.8172)
            };

            Pin pin4 = new Pin
            {
                Label = "This is  Banilad ",
                Address = "Brgy  Banilad ",
                Type = PinType.Place,
                Position = new Position(14.0730, 120.7408)
            };

            Pin pin5 = new Pin
            {
                Label = "This is  Barangay 1 ",
                Address = "Brgy  Barangay 1 ",
                Type = PinType.Place,
                Position = new Position(14.0752, 120.6296)
            };

            Pin pin6 = new Pin
            {
                Label = "This is  Barangay 10",
                Address = "Brgy  Barangay 10 ",
                Type = PinType.Place,
                Position = new Position(14.0694, 120.6301)
            };

            Pin pin7 = new Pin
            {
                Label = "This is  Barangay 11",
                Address = "Brgy  Barangay 11 ",
                Type = PinType.Place,
                Position = new Position(14.0604, 120.6344)
            };

            Pin pin8 = new Pin
            {
                Label = "This is  Barangay 12",
                Address = "Brgy  Barangay 12 ",
                Type = PinType.Place,
                Position = new Position(14.0639, 120.6358)
            };

            Pin pin9 = new Pin
            {
                Label = "This is  Barangay 2",
                Address = "Brgy  Barangay 2 ",
                Type = PinType.Place,
                Position = new Position(14.0783, 120.6300)
            };

            Pin pin10 = new Pin
            {
                Label = "This is  Barangay 3",
                Address = "Brgy  Barangay 3",
                Type = PinType.Place,
                Position = new Position(14.0724, 120.6307)
            };

            Pin pin11 = new Pin
            {
                Label = "This is  Barangay 4",
                Address = "Brgy  Barangay 4",
                Type = PinType.Place,
                Position = new Position(14.0735, 120.6343)
            };

            Pin pin12 = new Pin
            {
                Label = "This is  Barangay 5",
                Address = "Brgy  Barangay 5",
                Type = PinType.Place,
                Position = new Position(14.0756, 120.6343)
            };

            Pin pin13 = new Pin
            {
                Label = "This is  Barangay 6",
                Address = "Brgy  Barangay 6",
                Type = PinType.Place,
                Position = new Position(14.0684, 120.6374)
            };

            Pin pin14 = new Pin
            {
                Label = "This is  Barangay 7",
                Address = "Brgy  Barangay 7",
                Type = PinType.Place,
                Position = new Position(14.0694, 120.6351)
            };

            Pin pin15 = new Pin
            {
                Label = "This is  Barangay 8",
                Address = "Brgy  Barangay 8",
                Type = PinType.Place,
                Position = new Position(14.0698, 120.6337)
            };

            Pin pin16 = new Pin
            {
                Label = "This is  Barangay 9",
                Address = "Brgy  Barangay 9",
                Type = PinType.Place,
                Position = new Position(14.0695, 120.6324)
            };

            Pin pin17 = new Pin
            {
                Label = "This is  Bilaran",
                Address = "This is  Bilaran",
                Type = PinType.Place,
                Position = new Position(14.0487, 120.6846)
            };

            Pin pin18 = new Pin
            {
                Label = "This is  Bucana",
                Address = "This is  Bucana",
                Type = PinType.Place,
                Position = new Position(14.0678, 120.6267)
            };

            Pin pin19 = new Pin
            {
                Label = "This is  Bulihan",
                Address = "This is  Bulihan",
                Type = PinType.Place,
                Position = new Position(14.1552, 120.6540)
            };

            Pin pin20 = new Pin
            {
                Label = "This is  Bunducan",
                Address = "This is  Bunducan",
                Type = PinType.Place,
                Position = new Position(14.1069, 120.6521)
            };

            Pin pin21 = new Pin
            {
                Label = "This is  Butucan",
                Address = "This is  Butucan",
                Type = PinType.Place,
                Position = new Position(14.1394, 120.6805)
            };
             
            Pin pin22 = new Pin
            {
                Label = "This is  Calayo",
                Address = "This is  Calayo",
                Type = PinType.Place,
                Position = new Position(14.1461, 120.6141)
            };

            Pin pin23 = new Pin
            {
                Label = "This is  Catandaan",
                Address = "This is  Catandaan",
                Type = PinType.Place,
                Position = new Position(14.0804, 120.6815)
            };

            Pin pin24 = new Pin
            {
                Label = "This is  Cogunan",
                Address = "This is  Cogunan",
                Type = PinType.Place,
                Position = new Position(14.0625, 120.6555)
            };

            Pin pin25 = new Pin
            {
                Label = "This is  Dayap",
                Address = "This is  Dayap",
                Type = PinType.Place,
                Position = new Position(14.1013, 120.6627)
            };

            Pin pin26 = new Pin
            {
                Label = "This is  Kaylaway",
                Address = "This is  Kaylaway",
                Type = PinType.Place,
                Position = new Position(14.0747, 120.8172)
            };


            Pin pin27 = new Pin
            {
                Label = "This is  Kayrilaw",
                Address = "This is  Kayrilaw",
                Type = PinType.Place,
                Position = new Position(14.1027, 120.7819)
            };

            Pin pin28 = new Pin
            {
                Label = "This is  Latag",
                Address = "This is  Latag",
                Type = PinType.Place,
                Position = new Position(14.1164, 120.7124)
            };

            Pin pin29 = new Pin
            {
                Label = "This is  Looc",
                Address = "This is  Looc",
                Type = PinType.Place,
                Position = new Position(14.1641, 120.6295)
            };

            Pin pin30 = new Pin
            {
                Label = "This is  Lumbangan",
                Address = "This is  Lumbangan",
                Type = PinType.Place,
                Position = new Position(14.0494, 120.6597)
            };

            Pin pin31 = new Pin
            {
                Label = "This is  Malapad na Bato",
                Address = "This is  Malapad na Bato",
                Type = PinType.Place,
                Position = new Position(14.1116, 120.6828)
            };

            Pin pin32 = new Pin
            {
                Label = "This is  Mataas na Pulo",
                Address = "This is  Mataas na Pulo",
                Type = PinType.Place,
                Position = new Position(14.1122, 120.7452)
            };

            Pin pin33 = new Pin
            {
                Label = "This is  Maugat",
                Address = "This is  Maugat",
                Type = PinType.Place,
                Position = new Position(14.0868, 120.6767)
            };

            Pin pin34 = new Pin
            {
                Label = "This is  Munting Indan",
                Address = "This is  Munting Indan",
                Type = PinType.Place,
                Position = new Position(14.1031, 120.6985)
            };

            Pin pin35 = new Pin
            {
                Label = "This is Natipuan",
                Address = "This is  Natipuan",
                Type = PinType.Place,
                Position = new Position(14.1198, 120.6236)
            };

            Pin pin36 = new Pin
            {
                Label = "This is Pantalan",
                Address = "This is  Pantalan",
                Type = PinType.Place,
                Position = new Position(14.0907, 120.6323)
            };

            Pin pin37 = new Pin
            {
                Label = "This is Papaya",
                Address = "This is  Papaya",
                Type = PinType.Place,
                Position = new Position(14.1919, 120.6096)
            };

            Pin pin38 = new Pin
            {
                Label = "This is Putat",
                Address = "This is  Putat",
                Type = PinType.Place,
                Position = new Position(14.0788, 120.6527)
            };

            Pin pin39 = new Pin
            {
                Label = "This is Reparo",
                Address = "This is  Reparo",
                Type = PinType.Place,
                Position = new Position(14.0728, 120.6923)
            };

            Pin pin40 = new Pin
            {
                Label = "This is Talangan",
                Address = "This is  Talangan",
                Type = PinType.Place,
                Position = new Position(14.0777, 120.6358)
            };

            Pin pin41 = new Pin
            {
                Label = "This is Tumalim",
                Address = "This is  Tumalim",
                Type = PinType.Place,
                Position = new Position(14.0786, 120.7224)
            };

            Pin pin42 = new Pin
            {
                Label = "This is Utod",
                Address = "This is  Utod",
                Type = PinType.Place,
                Position = new Position(14.1195, 120.6479)
            };

            Pin pin43 = new Pin
            {
                Label = "This is Wawa",
                Address = "This is  Wawa",
                Type = PinType.Place,
                Position = new Position(14.0824, 120.6244)
            };

            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            map.Pins.Add(pin4);
            map.Pins.Add(pin5);
            map.Pins.Add(pin6);
            map.Pins.Add(pin7);
            map.Pins.Add(pin8);
            map.Pins.Add(pin9);
            map.Pins.Add(pin10);
            map.Pins.Add(pin11);
            map.Pins.Add(pin12);
            map.Pins.Add(pin13);
            map.Pins.Add(pin14);
            map.Pins.Add(pin15);
            map.Pins.Add(pin16);
            map.Pins.Add(pin17);
            map.Pins.Add(pin18);
            map.Pins.Add(pin19);
            map.Pins.Add(pin20);
            map.Pins.Add(pin21);
            map.Pins.Add(pin22);
            map.Pins.Add(pin23);
            map.Pins.Add(pin24);
            map.Pins.Add(pin25);
            map.Pins.Add(pin26);
            map.Pins.Add(pin27);
            map.Pins.Add(pin28);
            map.Pins.Add(pin29);
            map.Pins.Add(pin30);
            map.Pins.Add(pin31);
            map.Pins.Add(pin32);
            map.Pins.Add(pin33);
            map.Pins.Add(pin34);
            map.Pins.Add(pin35);
            map.Pins.Add(pin36);
            map.Pins.Add(pin37);
            map.Pins.Add(pin38);
            map.Pins.Add(pin39);
            map.Pins.Add(pin40);
            map.Pins.Add(pin41);
            map.Pins.Add(pin42);
            map.Pins.Add(pin43);

            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),
                                                         Distance.FromMiles(1)));
            pin1.MarkerClicked += Pin1_MarkerClicked;
            pin2.MarkerClicked += Pin2_MarkerClicked;
            pin3.MarkerClicked += Pin3_MarkerClicked;
            pin4.MarkerClicked += Pin4_MarkerClicked;
            pin5.MarkerClicked += Pin5_MarkerClicked;
            pin6.MarkerClicked += Pin6_MarkerClicked;
            pin7.MarkerClicked += Pin7_MarkerClicked;
            pin8.MarkerClicked += Pin8_MarkerClicked;
            pin9.MarkerClicked += Pin9_MarkerClicked;
            pin10.MarkerClicked += Pin10_MarkerClicked;
            pin11.MarkerClicked += Pin11_MarkerClicked;
            pin12.MarkerClicked += Pin12_MarkerClicked;
            pin13.MarkerClicked += Pin13_MarkerClicked;
            pin14.MarkerClicked += Pin14_MarkerClicked;
            pin15.MarkerClicked += Pin15_MarkerClicked;
            pin16.MarkerClicked += Pin16_MarkerClicked;
            pin17.MarkerClicked += Pin17_MarkerClicked;
            pin18.MarkerClicked += Pin18_MarkerClicked;
            pin19.MarkerClicked += Pin19_MarkerClicked;
            pin20.MarkerClicked += Pin20_MarkerClicked;
            pin21.MarkerClicked += Pin21_MarkerClicked;
            pin22.MarkerClicked += Pin22_MarkerClicked;
            pin23.MarkerClicked += Pin23_MarkerClicked;
            pin24.MarkerClicked += Pin24_MarkerClicked;
            pin25.MarkerClicked += Pin15_MarkerClicked;
            pin26.MarkerClicked += Pin26_MarkerClicked;
            pin27.MarkerClicked += Pin27_MarkerClicked;
            pin28.MarkerClicked += Pin28_MarkerClicked;
            pin29.MarkerClicked += Pin29_MarkerClicked;
            pin30.MarkerClicked += Pin30_MarkerClicked;
            pin31.MarkerClicked += Pin31_MarkerClicked;
            pin32.MarkerClicked += Pin32_MarkerClicked;
            pin33.MarkerClicked += Pin33_MarkerClicked;
            pin34.MarkerClicked += Pin34_MarkerClicked;
            pin35.MarkerClicked += Pin35_MarkerClicked;
            pin36.MarkerClicked += Pin36_MarkerClicked;
            pin37.MarkerClicked += Pin37_MarkerClicked;
            pin38.MarkerClicked += Pin38_MarkerClicked;
            pin39.MarkerClicked += Pin39_MarkerClicked;
            pin40.MarkerClicked += Pin40_MarkerClicked;
            pin41.MarkerClicked += Pin41_MarkerClicked;
            pin42.MarkerClicked += Pin42_MarkerClicked;
            pin43.MarkerClicked += Pin43_MarkerClicked;

        }

        private async void Pin43_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Wawa", "Minimal Raindall", "OK");
        }

        private async void Pin42_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Utod", "Minimal Raindall", "OK");
        }

        private async void Pin41_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Tumalim", "Minimal Raindall", "OK");
        }

        private async void Pin40_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Talangan", "Minimal Raindall", "OK");
        }

        private async void Pin39_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Reparo", "Minimal Raindall", "OK");
        }

        private async void Pin38_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Putat", "Minimal Raindall", "OK");
        }

        private async void Pin37_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Papaya", "Minimal Raindall", "OK");
        }

        private async void Pin36_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Pantalan", "Minimal Raindall", "OK");
        }

        private async void Pin35_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Natipuan", "Minimal Raindall", "OK");
        }

        private async void Pin34_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Munting Indan", "Minimal Raindall", "OK");
        }

        private async void Pin33_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Maugat", "Minimal Raindall", "OK");
        }

        private async void Pin32_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Mataas na Pulo", "Minimal Raindall", "OK");
        }

        private async void Pin31_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Malapad na Bato", "Minimal Raindall", "OK");
        }

        private async void Pin30_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Lumbangan", "Minimal Raindall", "OK");
        }

        private async void Pin29_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Looc", "Minimal Raindall", "OK");
        }

        private async void Pin28_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Latag", "Minimal Raindall", "OK");
        }

        private async void Pin27_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Kayrilaw", "Minimal Raindall", "OK");
        }

        private async void Pin26_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Kaylaway", "Minimal Raindall", "OK");
        }

        private async void Pin15_MarkerClicked1(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Dayap", "Minimal Raindall", "OK");
        }

        private async void Pin24_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Cogunan", "Minimal Raindall", "OK");
        }

        private async void Pin23_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Catandaan", "Minimal Raindall", "OK");
        }

        private async void Pin22_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Calayo", "Minimal Raindall", "OK");
        }

        private async void Pin21_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Butucan", "Minimal Raindall", "OK");
        }

        private async void Pin20_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Bunducan", "Minimal Raindall", "OK");
        }

        private async void Pin19_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Bulihan", "Minimal Raindall", "OK");
        }

        private async void Pin18_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Bucana", "Minimal Raindall", "OK");
        }

        private async void Pin17_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay Bilaran", "Minimal Raindall", "OK");
        }

        private async void Pin16_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 9", "Minimal Raindall", "OK");
        }

        private async void Pin15_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 8", "Minimal Raindall", "OK");
        }

        private async void Pin14_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 7", "Minimal Raindall", "OK");
        }

        private async void Pin13_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 6", "Minimal Raindall", "OK");
        }

        private async void Pin12_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 5", "Minimal Raindall", "OK");
        }

        private async void Pin11_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 4", "Minimal Raindall", "OK");
        }

        private async void Pin10_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 3", "Minimal Raindall", "OK");
        }

        private async void Pin9_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 2", "Minimal Raindall", "OK");
        }

        private async void Pin8_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 12", "Minimal Raindall", "OK");
        }

        private async void Pin7_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 11", "Minimal Raindall", "OK");
        }

        private async void Pin6_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 10", "Minimal Raindall", "OK");
        }

        private async void Pin5_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Barangay 1", "Minimal Raindall", "OK");
        }

        private async void Pin4_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Brgy Banilad", "Minimal Raindall", "OK");
        }

        private async void Pin3_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Brgy Balaytigui", "Minimal Raindall", "OK");
        }

        private async void Pin2_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Brgy AGA", "Minimal Raindall", "OK");
        }

        private async void Pin1_MarkerClicked(object sender, PinClickedEventArgs e)
        {
            await DisplayAlert("Nasugbu", "Heave Rainfall", "OK");
        }
    }
}