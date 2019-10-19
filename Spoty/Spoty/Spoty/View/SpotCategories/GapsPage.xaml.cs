using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spoty.ModeI;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Spoty.ViewModel;

namespace Spoty.View.SpotCategories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GapsPage : ContentPage
    {
        private SpotsListVM viewModel;

        public GapsPage()
        {
            InitializeComponent();

            viewModel = new SpotsListVM();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            gapsListView.ItemsSource = viewModel.GetSpots(SpotCategory.Gaps);
        }

        private void gapsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = gapsListView.SelectedItem as Spot;
            viewModel.GoToSpotDetail(spot);
        }
    }
}