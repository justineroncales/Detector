using Detector.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Detector.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}