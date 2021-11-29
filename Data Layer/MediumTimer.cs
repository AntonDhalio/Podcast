using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Data_Layer
{
    public class MediumTimer : SkapaTimer
    {
        public override void CreateTimer()
        {
            mediumTimer = new Timer();
            mediumTimer.Interval = 1000 * 30;
            mediumTimer.Enabled = true;
        }
    }
}
