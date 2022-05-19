using Detector.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Detector.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }
        public INavigation navigation { get; set; }

        //public LoginViewModel()
        //{
        //    LoginCommand = new Command(OnLoginClicked);
        //}

        //private async void OnLoginClicked()
        //{
        //    // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
        //    //await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        //    await navigation.PushAsync(new AboutPage());
        //}
    }
}
