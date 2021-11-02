using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace WinForm
{
    class ShortTimer : Intervall
    {
        public override void CreateTimer()
        {
            shortTimer = new Timer();
            shortTimer.Interval = 1000 * 5;
            shortTimer.Enabled = true;           
        }
    }
}
