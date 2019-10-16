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
    public partial class OthersPage : ContentPage
    {
        public OthersPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            othersListView.ItemsSource = DummySpotsData.Read(SpotCategory.Others);
        }

        private void othersListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = othersListView.SelectedItem as Spot;
            Navigation.PushModalAsync(new SpotDetailsPage(spot));
        }
    }
}