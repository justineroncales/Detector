using Detector.ViewModels;
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
    public partial class Monitoring : ContentPage
    {
        public Monitoring()
        {
            InitializeComponent();
            BindingContext = new MonitoringViewModel();
        }
    }
}