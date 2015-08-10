using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class VM : GenericModelBase<bool>
    {

        public VM()
        {
            value1 = true;
            value2 = false;
        }
    }
}
