﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class VM : GenericModelBase<string>
    {

        public VM()
        {
            value1 = "Yes";
            value2 = "No";
        }
    }
}
