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

namespace Spoty.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private MapVM viewmodel;

        public MapPage()
        {
            InitializeComponent();

            viewmodel = new MapVM(locationsMap);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            viewmodel.DisplayInMap();
            viewmodel.MoveMap();
        }
    }
}