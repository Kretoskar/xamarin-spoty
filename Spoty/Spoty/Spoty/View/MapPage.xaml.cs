using Spoty.ModeI;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoty.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private const float rzeszowLatitude = 50.041187f;
        private const float rzeszowLongitude = 21.999121f;
        private const float mapSpan = .2f;
        public MapPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DisplayInMap(DummySpotsData.Read());
            MoveMap();
        }

        private void DisplayInMap(List<Spot> spots)
        {
            foreach (var spot in spots)
            {
                try
                {
                    var position = new Xamarin.Forms.Maps.Position(spot.Latitude, spot.Longitude);

                    var pin = new Xamarin.Forms.Maps.Pin()
                    {
                        Type = Xamarin.Forms.Maps.PinType.SavedPin,
                        Position = position,
                        Label = spot.Name
                    };

                    locationsMap.Pins.Add(pin);
                }
                catch (NullReferenceException nre) { }
                catch (Exception ex) { }
            }
        }

        /// <summary>
        /// Center map on Rzeszów
        /// </summary>
        private void MoveMap()
        {
            var center = new Xamarin.Forms.Maps.Position(rzeszowLatitude, rzeszowLongitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, mapSpan, mapSpan);
            locationsMap.MoveToRegion(span);
        }
    }
}