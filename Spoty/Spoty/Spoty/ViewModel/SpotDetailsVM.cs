using Spoty.ModeI;
using Spoty.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace Spoty.ViewModel
{
    public class SpotDetailsVM
    {
        public NavigateToClickedSpotCommand NavCommand { get; set; }
        public Spot ClickedSpot { get; set; }

        public SpotDetailsVM(Spot spot)
        {
            ClickedSpot = spot;
            NavCommand = new NavigateToClickedSpotCommand(this);
        }

        public async void NavigateToClickedSpot()
        {
            var location = new Location(ClickedSpot.Latitude, ClickedSpot.Longitude);
            var options = new MapLaunchOptions { Name = ClickedSpot.Name, NavigationMode = NavigationMode.Driving };
            await Map.OpenAsync(location, options);
        }
    }
}
