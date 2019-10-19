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
    public partial class RailsPage : ContentPage
    {
        private SpotsListVM viewModel;

        public RailsPage()
        {
            InitializeComponent();

            viewModel = new SpotsListVM();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            railsListView.ItemsSource = viewModel.GetSpots(SpotCategory.Rails);
        }

        private void railsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = railsListView.SelectedItem as Spot;
            viewModel.GoToSpotDetail(spot);
        }
    }
}