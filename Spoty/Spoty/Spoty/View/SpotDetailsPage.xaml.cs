using Spoty.ModeI;
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
    public partial class SpotDetailsPage : ContentPage
    {
        public Spot ClickedSpot { get; set; }

        public SpotDetailsPage(Spot spot)
        {
            ClickedSpot = spot;
            InitializeComponent();
            stackLayout.BindingContext = spot;
        }
    }
}