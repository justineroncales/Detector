
using Detector.Models;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Detector.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            
        }

        public ICommand OpenWebCommand { get; }

        public async void SetMapPin()
        {


            Map map = new Map
            {
                // ...
            };
            Pin pin1 = new Pin
            {
                Label = "This is Kay Laway",
                Address = "Kay Laway",
                Type = PinType.Place,
                Position = new Position(14.0747, 120.8172)
            };
            Pin pin2 = new Pin
            {
                Label = "This is Kay Laway",
                Address = "Kay Laway",
                Type = PinType.Place,
                Position = new Position(14.0747, 120.8172)
            };
            Pin pin3 = new Pin
            {
                Label = "This is Kay Laway",
                Address = "Kay Laway",
                Type = PinType.Place,
                Position = new Position(14.0747, 120.8172)
            };
            map.Pins.Add(pin1);
            map.Pins.Add(pin2);
            map.Pins.Add(pin3);
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(10));
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude),
                                                         Distance.FromMiles(1)));
        }
    }
}