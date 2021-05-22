using System;

namespace TechTrainLineCodeingTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var input = new ParseInput().Parse(); 
            var fare = new CalcFare(new CalcDistanceFare(RunningLogToDistanceFareList.Convert(input)), new CalcSpeedFare(RunningLogToSpeedFareList.Convert(input))).Calc();
            Console.WriteLine(fare);
        }
    }
}