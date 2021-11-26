using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;


namespace Data_Layer
{
    public class SkapaTimer
    {
        public static Timer timer;
        public static Timer shortTimer;
        public static Timer mediumTimer;
        public static Timer longTimer;
        public virtual void CreateTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
        }
    }
}
