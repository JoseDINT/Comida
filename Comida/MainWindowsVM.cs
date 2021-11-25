using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowsVM : INotifyPropertyChanged
    {
        private ObservableCollection<string> comidas;
        public ObservableCollection<string> Comidas
        {


        }





        public event PropertyChangedEventHandler PropertyChanged;
    }
}
