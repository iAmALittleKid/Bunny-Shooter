using System;
using System.Timers;

namespace Bunny_Shooter.Handlers
{
    public class TimerHandler
    {
        private static Timer aTimer;

        public static void Main()
        {
            setTimer();

            aTimer.Stop();
            aTimer.Dispose();
        }

        private static void setTimer()
        {
            aTimer = new Timer(10000);

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
