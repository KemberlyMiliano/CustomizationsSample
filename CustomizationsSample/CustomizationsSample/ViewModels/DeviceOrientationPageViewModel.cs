using CustomizationsSample.Models;
using CustomizationsSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomizationsSample.ViewModels
{
    public class DeviceOrientationPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public OrientationText Text { get; set; } = new OrientationText();
        public DeviceOrientationPageViewModel()
        {

        }


    }
}
