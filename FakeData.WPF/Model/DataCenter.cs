using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class DataCenter : CustomNotifyPropertyChanged
    {
        #region Properties

        private string dataCenter1;

        public string DataCenter1
        {
            get
            {
                return dataCenter1;
            }
            set
            {
                dataCenter1 = value;
                NotifyPropertyChanged();
            }
        }

        private string dataCenter2;

        public string DataCenter2
        {
            get { return dataCenter2; }
            set
            {
                dataCenter2 = value;
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
