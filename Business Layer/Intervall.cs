using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;

namespace Business_Layer
{
    public class Intervall
    {
        public delegate void UpdatePodcasts(string tidsintervall);
        public event UpdatePodcasts TimerAvklaradShort;
        public event UpdatePodcasts TimerAvklaradMedium;
        public event UpdatePodcasts TimerAvklaradLong;

        public static Timer timer;
        public static Timer shortTimer;
        public static Timer mediumTimer;
        public static Timer longTimer;

      
        public void ActivateTimer()
        {         
            shortTimer.Elapsed += OnTimedEvent1;
            mediumTimer.Elapsed += OnTimedEvent2;
            longTimer.Elapsed += OnTimedEvent3;          
        }
        public void OnTimedEvent1(Object source, System.Timers.ElapsedEventArgs e)
        {
            TimerAvklaradShort("5 sekunder");
        }

        public void OnTimedEvent2(Object source, System.Timers.ElapsedEventArgs e)
        {
            TimerAvklaradMedium("30 sekunder");
        }

        public void OnTimedEvent3(Object source, System.Timers.ElapsedEventArgs e)
        {
            TimerAvklaradLong("60 sekunder");
        }
    }
}
