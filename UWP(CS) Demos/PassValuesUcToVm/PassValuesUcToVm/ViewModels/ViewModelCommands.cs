using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Controls;
using PassValuesUcToVm.Models;

namespace PassValuesUcToVm.ViewModels
{
    public class ViewModelCommands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //if it's a tapped event
            if (parameter is TappedRoutedEventArgs)
            {
                var tappedEvent = (TappedRoutedEventArgs)parameter;
                var gridSource = (Grid)tappedEvent.OriginalSource;
                var dataContext = (MainPageModel)gridSource.DataContext;
                //if tick is true then set to false, or the opposite.
                if (dataContext.isFav == null)
                {
                    dataContext.isFav = true;
                } else
                {
                    dataContext.isFav = !dataContext.isFav;
                }
            }
        }
    }
}
