using Detector.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace Detector.ViewModels
{
    public class MonitoringViewModel : INotifyPropertyChanged
    {
        private List<Locations> _location;

        public List<Locations> Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public  MonitoringViewModel()
        {
            _ = getLocAsync();
        }

        private async Task getLocAsync()
        {
            Location = await Locations.GetLocationsAsync();
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
