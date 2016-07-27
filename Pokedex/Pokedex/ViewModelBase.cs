using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        // Setting an empty delegate is not strictly necessary, but it removes the need
        // for null checks for a miniscule performance hit.
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        // Manually setup property change notification so that the UI will be notified when values change.
        // This allows bound values to update in the UI.
        // I would usually use a framework like MvvmLight or MvvmCross to handle this for me.
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
