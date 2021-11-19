using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Repaso_Mysql_Xamarin
{
    public partial class App : Application
    {
        public static string url;
        public App()
        {
            InitializeComponent();
            url = "https://examenpm2.000webhostapp.com/ProyectoMySql/";
            MainPage = new NavigationPage(new MainPage());
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
