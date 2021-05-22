using System.Collections.Generic;
using System.Linq;

namespace TechTrainLineCodeingTest
{
    public class CalcSpeedFare
    {
        private List<RunningSpeed> _speedFaresList;
        public CalcSpeedFare(List<RunningSpeed> speedFaresList)
        {
            _speedFaresList = speedFaresList;
        }
        public int Calc()
        {
            return _speedFaresList.Sum(RunningSpeedToFare);
        }

        private int RunningSpeedToFare(RunningSpeed runningSpeed)
        {
            if (10 < runningSpeed.Speed) return 0;
            
            int f = (int)(runningSpeed.Second / 90);
            return f*80;
        }
    }
}