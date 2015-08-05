using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class DeviceType : CustomNotifyPropertyChanged
    {
        #region Properties

        private string deviceType1;

        public string DeviceType1
        {
            get
            {
                return deviceType1;
            }
            set
            {
                deviceType1 = value;
                NotifyPropertyChanged();
            }
        }

        private string deviceType2;

        public string DeviceType2
        {
            get { return deviceType2; }
            set
            {
                deviceType2 = value;
                NotifyPropertyChanged();
            }
        }

        private int value1;

        public int Value1
        {
            get { return value1; }
            set
            {
                value1 = value;
                NotifyPropertyChanged();
            }
        }

        private int value2;

        public int Value2
        {
            get { return value2; }
            set
            {
                value2 = value;
                NotifyPropertyChanged();
            }
        }

        private ValueOption option1 = ValueOption.Amount;

        public ValueOption Option1
        {
            get { return option1; }
            set { option1 = value; NotifyPropertyChanged(); }
        }

        private ValueOption option2 = ValueOption.Amount;

        public ValueOption Option2
        {
            get { return option2; }
            set { option2 = value; }
        }

        #endregion
    }
}
