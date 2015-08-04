using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class ScanTime : CustomNotifyPropertyChanged
    {

        #region Properties

        private DateTime date1 = DateTime.Now;

        public DateTime Date1
        {
            get { return date1; }
            set { date1 = value; NotifyPropertyChanged(); }
        }

        private DateTime date2 = DateTime.Now;

        public DateTime Date2
        {
            get { return date2; }
            set
            {
                date2 = value;
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
            set { option2 = value; NotifyPropertyChanged(); }
        }

        #endregion
    }
}
