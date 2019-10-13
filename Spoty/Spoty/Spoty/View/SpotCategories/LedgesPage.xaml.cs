﻿using Spoty.ModeI;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoty.View.SpotCategories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LedgesPage : ContentPage
    {
        public LedgesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
            {
                conn.CreateTable<Spot>();
                var spots = conn.Table<Spot>().ToList();
                List<Spot> ledgesSpots = new List<Spot>();
                foreach (Spot spot in spots)
                {
                    if (spot.Categories == SpotCategory.Ledges)
                        ledgesSpots.Add(spot);
                }
                ledgesListView.ItemsSource = ledgesSpots;
            }
        }
    }
}