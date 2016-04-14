using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Mvvm;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using PassValuesUcToVm.Models;

namespace PassValuesUcToVm.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ObservableCollection<MainPageModel> _sampleList = new ObservableCollection<MainPageModel>();

        public ViewModelCommands Commands { get; set; }
        public ObservableCollection<MainPageModel> sampleList
        {
            get
            {
                return this._sampleList;
            }
            set
            {
                Set(ref _sampleList, value);
            }
        }
        public MainPageViewModel()
        {
            if (Windows.ApplicationModel.DesignMode.DesignModeEnabled)
                Value = "Designtime value";

            var temp = GetData();
        }

        string _Value = string.Empty;
        public string Value { get { return _Value; } set { Set(ref _Value, value); } }

        public override Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            if (state.ContainsKey(nameof(Value)))
                Value = state[nameof(Value)]?.ToString();
            state.Clear();
            return Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending)
        {
            if (suspending)
                state[nameof(Value)] = Value;
            await Task.Yield();
        }

        public async Task GetData()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                    sampleList.Add(new MainPageModel { sampleText = "Selected", isFav = true });
                else
                    sampleList.Add(new MainPageModel { sampleText = "UnSelected", isFav = null });
            }
        }
        
    }
}

