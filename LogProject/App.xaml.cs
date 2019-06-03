using System;
using GalaSoft.MvvmLight.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LogProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SimpleIoc.Default.Register<ICloudLogService, CloudLogService>();
            SimpleIoc.Default.Register<ILogService, LogService>();
            SimpleIoc.Default.Register<ViewModel>();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            SimpleIoc.Default.GetInstance<ICloudLogService>().Initialize("android=efee667a-d89a-4972-b2d4-f9ccc11276c7;ios=775b13a4-b4d6-48cb-982e-d5e0e57f4b5c;");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
