using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private async void SIButton_Clicked(object sender, EventArgs e)
        {
            blackScreen.IsVisible = true;

            await Task.Delay(2000);
            blackScreen.IsVisible = false;

            App.Current.MainPage = new MainPage();
        }

        private void SUButton_Clicked(object sender, EventArgs e)
        {

        }


        //private void trabB_Clicked(object sender, EventArgs e)
        //{
        //    var text = phoneword.Text;
        //    var tranlasted = text.FromWordToNumber();
        //    phoneword.Text = tranlasted;

        //    if (tranlasted != "INVALID NUMBER")
        //    {
        //        callB.IsEnabled = true;
        //    }
        //}

        //private async void callB_Clicked(object sender, EventArgs e)
        //{
        //    if (await DisplayAlert("Dial a number", $"Woukd u like to call {phoneword.Text}?", "Sure", "No way"))
        //    {
        //        var dialer = DependencyService.Get<IDial>();
        //        if (dialer != null)
        //        {
        //            await dialer.DialAsync(phoneword.Text);
        //        }
        //    }
        //}

        //private async void Button_Clicked(object sender, EventArgs e)
        //{
        //    var email = this.email.Text;
        //    var password = this.password.Text;
        //    var msg = "Failed to sign with " + "email = " + email + " and " + "password = " + password + ".";

        //    await DisplayAlert(
        //       title: "Sign In",
        //       message: msg,
        //       accept: "Ok",
        //       cancel: "No"
        //        );
        //}
    }
}
