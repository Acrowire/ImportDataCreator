using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class GenericModelBase<T> : ModelBase<T>
    {
        public T value1;
        public T value2;

        public override T Value1
        {
            get
            {
                return value1;
            }

            set
            {
                value1 = value;
                NotifyPropertyChanged();
            }
        }

        public override T Value2
        {
            get
            {
                return value2;
            }

            set
            {
                value2 = (T)value;
                NotifyPropertyChanged();
            }
        }
    }
}
