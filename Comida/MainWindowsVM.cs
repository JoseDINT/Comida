using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Comida
{
    class MainWindowsVM : INotifyPropertyChanged
    {
        //private ObservableCollection<Plato> comidas;
        private ObservableCollection<String> tiposComidas = new ObservableCollection<string>();
        public ObservableCollection<String> TiposComidas
        {
            get
            {
                return tiposComidas;
            }
            set
            {
                tiposComidas = value;
                INotifyPropertyChanged("TiposComida");
            }

        }


        //public ObservableCollection<Plato> Comidas
        //{
        //    get
        //    {
        //        return comidas;
        //    }
        //    set
        //    {
        //        comidas = value;
        //        INotifyPropertyChanged("Comidas");
        //    }
        //}


        public void CrearLista()
        {
            TiposComidas.Add("Americana");
            TiposComidas.Add("China");
            TiposComidas.Add("Mejicana");
        }

        public void INotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainWindowsVM()
        {
            CrearLista();
        }
    }
}
