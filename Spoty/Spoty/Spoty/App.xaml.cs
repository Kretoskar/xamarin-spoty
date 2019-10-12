using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Spoty.ModeI;
using System.Collections.Generic;

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

            using (SQLiteConnection conn = new SQLiteConnection(DatabasaLocation))
            {
                DummySpotsData dummySpotsData = new DummySpotsData();
                foreach (Spot spot in dummySpotsData.Spots)
                {
                    conn.CreateTable<Spot>();
                    conn.Insert(spot);
                }
                string connstr = conn.ToString();
            }
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
