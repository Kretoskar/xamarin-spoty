using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Spoty.ModeI;
using System.Collections.Generic;
using System.IO;
using Spoty.View.SpotCategories;

namespace Spoty
{
    public partial class App : Application
    {
        public static string DatabasaLocation = string.Empty;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public App(string databaseLocation) 
        {
            InitializeComponent();

            MainPage = new MainPage();

            DatabasaLocation = databaseLocation;

            DummySpotsData.SetupDatabase();
        }


        protected override void OnStart()
        {
            // Handle when your app starts
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
