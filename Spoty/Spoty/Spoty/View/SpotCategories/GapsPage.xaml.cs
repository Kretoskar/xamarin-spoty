﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spoty.ModeI;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoty.View.SpotCategories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GapsPage : ContentPage
    {
        public GapsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            gapsListView.ItemsSource = DummySpotsData.Read(SpotCategory.Gaps);
        }

        private void gapsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = gapsListView.SelectedItem as Spot;
            Navigation.PushModalAsync(new SpotDetailsPage(spot));
        }
    }
}