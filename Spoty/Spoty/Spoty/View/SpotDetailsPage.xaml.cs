using Spoty.ModeI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Spoty.ViewModel;

namespace Spoty.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpotDetailsPage : ContentPage
    {
        private SpotDetailsVM viewModel;

        public SpotDetailsPage(Spot spot)
        {
            InitializeComponent();

            stackLayout.BindingContext = spot;

            viewModel = new SpotDetailsVM(spot);
            navButton.BindingContext = viewModel;
        }
    }
}