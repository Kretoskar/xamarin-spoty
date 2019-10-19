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
    public partial class OthersPage : ContentPage
    {
        private SpotsListVM viewModel;

        public OthersPage()
        {
            InitializeComponent();

            viewModel = new SpotsListVM();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            othersListView.ItemsSource = viewModel.GetSpots(SpotCategory.Others);
        }

        private void othersListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = othersListView.SelectedItem as Spot;
            viewModel.GoToSpotDetail(spot);
        }
    }
}