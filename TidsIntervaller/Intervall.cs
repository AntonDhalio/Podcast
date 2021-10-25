using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace TidsIntervaller
{
    public class Inervall
    {
        public static Timer shortTimer;
        public static Timer mediumTimer;
        public static Timer longTimer;

        public void CreateTimers()
        {
            shortTimer = new System.Timers.Timer();
            shortTimer.Interval = 1000 * 5;
            shortTimer.Enabled = true;

            mediumTimer = new System.Timers.Timer();
            mediumTimer.Interval = 1000 * 30;
            mediumTimer.Enabled = true;

            longTimer = new System.Timers.Timer();
            longTimer.Interval = 1000 * 60;
            longTimer.Enabled = true;
        }
        public void testTimer()
        {
            shortTimer.Elapsed += OnTimedEvent;
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("Det har gått 5 sekunder");
        }
    }
}
