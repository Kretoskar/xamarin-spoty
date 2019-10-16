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
    public partial class LedgesPage : ContentPage
    {
        public LedgesPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ledgesListView.ItemsSource = DummySpotsData.Read(SpotCategory.Ledges);
        }

        private void ledgesListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Spot spot = ledgesListView.SelectedItem as Spot;
            Navigation.PushModalAsync(new SpotDetailsPage(spot));
        }
    }
}