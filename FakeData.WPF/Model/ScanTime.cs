﻿using FakeData.WPF.ViewModels.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeData.WPF.Model
{
    public class ScanTime : GenericModelBase<DateTime>
    {
        public ScanTime()
        {
            value1 = DateTime.Now;

            value2 = DateTime.Now;
        }

        #region Properties
        // Custom Properties
        #endregion

    }
}
