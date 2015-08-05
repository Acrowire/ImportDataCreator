using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public abstract class ModelBase<T> : CustomNotifyPropertyChanged
    {
        public abstract T Value1
        {
            get; set;
        }

        public abstract T Value2
        {
            get; set;
        }

        private int amount1;

        public int Amount1
        {
            get { return amount1; }
            set { amount1 = value; NotifyPropertyChanged(); }
        }

        private int amount2;

        public int Amount2
        {
            get { return amount2; }
            set { amount2 = value; NotifyPropertyChanged(); }
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
    }
}
