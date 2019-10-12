using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spoty.ModeI;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spoty.View.SpotCategories
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GapsPage : ContentPage
    {
        public GapsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabasaLocation))
            {
                conn.CreateTable<Spot>();
                var posts = conn.Table<Spot>().ToList();
                gapsListView.ItemsSource = posts;
            }
        }
    }
}