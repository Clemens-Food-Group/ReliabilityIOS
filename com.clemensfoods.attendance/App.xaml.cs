using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using com.clemensfoods.attendance.Services;
using com.clemensfoods.attendance.Views;

namespace com.clemensfoods.attendance
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new Start());
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
