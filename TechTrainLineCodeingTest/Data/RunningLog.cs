using System;

namespace TechTrainLineCodeingTest
{
    public class RunningLog
    {
        public int Hour { get; }
        public int Min { get; }
        public int Sec { get; }
        public int MiliSec { get; }
        public double Distance { get; }

        public RunningLog(string oneLineLog)
        {
            string[] space = oneLineLog.Split(' ');
            Distance = Double.Parse(space[1]);
            if (99.9 < Distance) throw new ArgumentOutOfRangeException();
            
            string[] decimal_ = space[0].Split('.');
            MiliSec = Int32.Parse(decimal_[1]);
            if (999 < MiliSec) throw new ArgumentOutOfRangeException();

            string[] coron = decimal_[0].Split(':');
            Hour = Int32.Parse(coron[0]);
            Min = Int32.Parse(coron[1]);
            Sec = Int32.Parse(coron[2]);
            
            if (99 < Hour) throw new ArgumentOutOfRangeException();
            if (60 < Min) throw new ArgumentOutOfRangeException();
            if (60 < Sec) throw new ArgumentOutOfRangeException();
            
        }
    }
}