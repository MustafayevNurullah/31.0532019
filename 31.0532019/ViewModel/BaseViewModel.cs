using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._0532019.ViewModel
{

    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnpropertyChange(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this,e);
        }
    }
}
