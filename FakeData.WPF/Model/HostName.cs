using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class HostName : GenericModelBase<string>
    {
        public HostName()
        {
            Value1 = "host-";
        }
    }
}
