using Spoty.ModeI;
using Spoty.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spoty.ViewModel
{
    class SpotsListVM
    {
        public SpotsListVM ()
        {
        }

        public void GoToSpotDetail(Spot spot)
        {
            App.Current.MainPage.Navigation.PushModalAsync(new SpotDetailsPage(spot));
        }

        public List<Spot> GetSpots(SpotCategory category)
        {
            return DummySpotsData.Read(category);
        }
    }
}
