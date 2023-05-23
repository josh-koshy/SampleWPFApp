using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    using System.ComponentModel;
    using System.Windows.Input;
    using System;

    public class MyViewModel : INotifyPropertyChanged
    {
        private MyModel _model = new MyModel();

        public string Data
        {
            get { return _model.Data; }
            set
            {
                if (_model.Data != value)
                {
                    _model.Data = value;
                    OnPropertyChanged("Data");
                }
            }
        }

        public ICommand UpdateDataCommand
        {
            get
            {
                return new RelayCommand(UpdateData, CanUpdateData);
            }
        }

        private void UpdateData(object parameter)
        {
            Data = "Data Updated";
        }

        private bool CanUpdateData(object parameter)
        {
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
