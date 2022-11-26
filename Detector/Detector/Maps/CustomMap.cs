using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.GoogleMaps;

namespace Detector.Maps
{
    public class CustomMap : Map
    {
        public List<CustomPin> CustomPins { get; set; }
    }
    public class CustomPin : Pin
    {

        public CustomPin(string Name, int id, double Latitude, double Longitude)
        {
            this.Name = Name;
            this.id = id;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        public string Name { get; set; }
        public int id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
