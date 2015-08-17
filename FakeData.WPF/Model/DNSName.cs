using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class DNSName : GenericModelBase<string>
    {
        public DNSName()
        {
            Value1 = "host-";
        }
    }
}
