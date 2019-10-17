using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Spoty.ViewModel.Commands
{
    public class NavigateToClickedSpotCommand : ICommand
    {
        public SpotDetailsVM SpotDetailsViewModel { get; set; }

        public NavigateToClickedSpotCommand(SpotDetailsVM spotDetailsVM)
        {
            this.SpotDetailsViewModel = spotDetailsVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SpotDetailsViewModel.NavigateToClickedSpot();
        }
    }
}
