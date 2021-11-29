using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Data_Layer
{
    public class LongTimer : SkapaTimer
    {
        public override void CreateTimer()
        {
            longTimer = new Timer();
            longTimer.Interval = 1000 * 60;
            longTimer.Enabled = true;
        }
    }
}
