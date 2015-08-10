using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class ModelStarted : GenericModelBase<DateTime>
    {
        public ModelStarted()
        {
            value1 = DateTime.Now;
            value2 = DateTime.Now;
        }
    }
}
