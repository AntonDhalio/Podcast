using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Business_Layer
{
    public class MediumTimer : Intervall
    {
        public override void CreateTimer()
        {
            mediumTimer = new Timer();
            mediumTimer.Interval = 1000 * 30;
            mediumTimer.Enabled = true;
        }
    }
}
