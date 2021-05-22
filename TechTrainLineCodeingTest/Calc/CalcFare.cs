namespace TechTrainLineCodeingTest
{
    public class CalcFare
    {
        private CalcDistanceFare _calcDistanceFare;
        private CalcSpeedFare _calcSpeedFare;
        
        public CalcFare(CalcDistanceFare calcDistanceFare, CalcSpeedFare calcSpeedFare)
        {
            _calcDistanceFare = calcDistanceFare;
            _calcSpeedFare = calcSpeedFare;
        }

        public int Calc()
        {
            return _calcDistanceFare.Calc() + _calcSpeedFare.Calc();
        }
    }
}