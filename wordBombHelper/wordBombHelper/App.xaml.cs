using System;
using System.IO;
using wordBombHelper.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wordBombHelper
{
    public partial class App : Application
    {
        

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PlayerPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.Aquamarine
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
