
using CustomizationsSample.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CustomizationsSample.Models
{
    public class OrientationText : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public const string Text = "My device orientation is";

        private string message;
        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                DeviceOrientation orientation = DependencyService.Get<IGetDeviceOrientation>().GetDeviceOrientation();
                if (orientation == DeviceOrientation.Portrait)
                {
                    this.message = $"{Text} Portrait";
                }

                else if (orientation == DeviceOrientation.Landscape)
                {
                    this.message = $"{Text} Landscape";
                }

            }
        }

    }
}
