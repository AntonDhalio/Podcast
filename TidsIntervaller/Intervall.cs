using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace TidsIntervaller
{
    public class Inervall
    {
        public delegate void UpdatePodcasts();
        //public static event UpdatePodcasts TimerAvklaradShort;
        //public static event UpdatePodcasts TimerAvklaradMedium;
        //public static event UpdatePodcasts TimerAvklaradLong;

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
        public void activateTimer()
        {
            shortTimer.Elapsed += OnTimedEvent1;
            mediumTimer.Elapsed += OnTimedEvent2;
            longTimer.Elapsed += OnTimedEvent3;
        }
        public static void OnTimedEvent1(Object source, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("Det har gått 5 sekunder");
            // TimerAvklaradShort();
        }

        public static void OnTimedEvent2(Object source, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("Det har gått 30 sekunder");
            // TimerAvklaradMedium();
        }

        public static void OnTimedEvent3(Object source, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine("Det har gått 60 sekunder");
            // TimerAvklaradLong();
        }
    }
}
