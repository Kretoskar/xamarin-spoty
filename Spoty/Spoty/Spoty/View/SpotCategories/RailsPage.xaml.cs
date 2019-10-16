using Spoty.ModeI;
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
        public RailsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            railsListView.ItemsSource = DummySpotsData.Read(SpotCategory.Rails);
        }

        private void railsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = railsListView.SelectedItem as Spot;
            Navigation.PushModalAsync(new SpotDetailsPage(spot));
        }
    }
}