using Spoty.ModeI;
using Spoty.ViewModel;
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
        private SpotsListVM viewModel;

        public LedgesPage()
        {
            InitializeComponent();

            viewModel = new SpotsListVM();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ledgesListView.ItemsSource = viewModel.GetSpots(SpotCategory.Ledges);
        }

        private void ledgesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = ledgesListView.SelectedItem as Spot;
            viewModel.GoToSpotDetail(spot);
        }
    }
}