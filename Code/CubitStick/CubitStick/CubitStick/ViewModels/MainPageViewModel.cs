using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace CubitStick
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            SettingsCommand = new Command(() => { Debug.WriteLine("Settings"); });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command SettingsCommand;
    }
}
