using System;
using System.ComponentModel;

namespace CubitStick
{
    public class MeasurementViewModel : INotifyPropertyChanged
    {
        public MeasurementViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
