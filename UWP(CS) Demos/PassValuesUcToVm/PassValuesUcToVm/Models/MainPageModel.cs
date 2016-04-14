using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;
using PassValuesUcToVm.ViewModels;

namespace PassValuesUcToVm.Models
{
    public class MainPageModel:BindableBase
    {

        public MainPageModel() {
            favTapped = new ViewModelCommands();
        }
        public ViewModelCommands favTapped { get; set; }
        private string _sampleText;
        public string sampleText
        {
            get
            {
                return this._sampleText;
            }
            set
            {
                Set(ref _sampleText, value);
            }
        }
        private bool? _isFav;
        public bool? isFav
        {
            get
            {
                return this._isFav;
            }
            set
            {
                Set(ref _isFav, value);
            }
        }
    }
}
