using Plugin.Settings;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamarinTest
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //CrossSettings.Current.GetValueOrDefault("token", null); // install-package xam.plugins.settings

            if (Settings.Token != null) // this.Properties.ContainsKey("token")
                MainPage = new MainPage();
            else
			    MainPage = new LogInPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
