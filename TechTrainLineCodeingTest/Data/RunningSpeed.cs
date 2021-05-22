using System;

namespace TechTrainLineCodeingTest
{
    public class RunningSpeed
    {
        public double Speed { get; }
        public double Second { get; }
        public RunningSpeed(RunningLog prev, RunningLog next)
        {
            Second = (next.Hour - prev.Hour) * 3600 + (next.Min - prev.Min) * 60 + (next.Sec - prev.Sec) + (next.MiliSec - prev.MiliSec)/100;
            var distance = next.Distance - prev.Distance;
            Speed = distance / Second*3600/1000;
            if (IsMidnight.Judg(prev, next))
            {
                Second *= 1.25;
            }
            
            if (Second < 0) throw new ArgumentOutOfRangeException();
        }
    }
}