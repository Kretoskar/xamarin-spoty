using Spoty.ModeI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Spoty.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpotDetailsPage : ContentPage
    {
        public Spot ClickedSpot { get; set; }

        public SpotDetailsPage(Spot spot)
        {
            ClickedSpot = spot;
            InitializeComponent();
            stackLayout.BindingContext = spot;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //string url = "";
            //switch(Device.RuntimePlatform)
            //{
            //    case (Device.Android):
            //        //url = String.Format("http://maps.google.com/maps?q={0}", address);
            //        url = String.Format("http://maps.google.com/maps?q");
            //        break;
            //    default:
            //        //IOS intent
            //        break;

            //}
            //Device.OpenUri(new System.Uri(url));
            NavigateToClickedSpot();
        }

        public async Task NavigateToClickedSpot()
        {
            var location = new Location(ClickedSpot.Latitude, ClickedSpot.Longitude);
            var options = new MapLaunchOptions { Name = ClickedSpot.Name, NavigationMode = NavigationMode.Driving };
            await Map.OpenAsync(location, options);
        }
    }
}