﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace WinForm
{
    class MediumTimer : Intervall
    {
        public override void CreateTimer()
        {
            mediumTimer = new Timer();
            mediumTimer.Interval = 1000 * 5;
            mediumTimer.Enabled = true;
        }
    }
}
