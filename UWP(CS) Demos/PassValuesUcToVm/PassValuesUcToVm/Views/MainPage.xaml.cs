using PassValuesUcToVm.ViewModels;
using System;
using Windows.UI.Xaml.Controls;

namespace PassValuesUcToVm.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
        }
        //public MainPageViewModel ViewModel => this.DataContext as MainPageViewModel;
    }
}
