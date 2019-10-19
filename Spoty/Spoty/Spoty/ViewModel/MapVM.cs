using Spoty.ModeI;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace Spoty.ViewModel
{
    class MapVM
    {
        private const float rzeszowLatitude = 50.041187f;
        private const float rzeszowLongitude = 21.999121f;
        private const float mapSpan = .2f;
        private Map map;
        public MapVM (Map map)
        {
            this.map = map;
        }

        /// <summary>
        /// Center map on Rzeszów
        /// </summary>
        public void MoveMap()
        {
            var center = new Xamarin.Forms.Maps.Position(rzeszowLatitude, rzeszowLongitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, mapSpan, mapSpan);
            map.MoveToRegion(span);
        }

        public void DisplayInMap()
        {
            var spots = DummySpotsData.Read();

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

                    map.Pins.Add(pin);
                }
                catch (NullReferenceException nre) { }
                catch (Exception ex) { }
            }
        }
    }
}
