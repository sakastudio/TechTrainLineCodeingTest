using System;
using System.Collections.Generic;
using System.Linq;

namespace TechTrainLineCodeingTest
{
    public class CalcDistanceFare
    {
        private List<RunningDistance> _distanceFaresList;
        private const int FirstRideDistance = 1052;
        private const int FirstRideFare = 410;
        private const int AddFareDistance = 237;
        private const int AddFare = 80;
        public CalcDistanceFare(List<RunningDistance> distanceFaresList)
        {
            _distanceFaresList = distanceFaresList;
        }
        public int Calc()
        {
            var sumDis = _distanceFaresList.Sum(i => i.Distance);
            sumDis -= FirstRideDistance;
            if (sumDis <= 0) return FirstRideFare;

            return ((int) (sumDis % AddFareDistance) + 1) * AddFare;
        }
    }
}