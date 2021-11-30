using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Business_Layer
{
    public class LongTimer : Intervall
    {
        public override void CreateTimer()
        {
            longTimer = new Timer();
            longTimer.Interval = 1000 * 60;
            longTimer.Enabled = true;
        }
    }
}
