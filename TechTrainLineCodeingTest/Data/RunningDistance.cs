namespace TechTrainLineCodeingTest
{
    public class RunningDistance
    {
        public double Distance { get; }
        public RunningDistance(RunningLog prev, RunningLog next)
        {
            if (IsMidnight.Judg(prev, next))
            {
                Distance = next.Distance - prev.Distance;
                Distance *= 1.25;
            }
            else
            {
                Distance = next.Distance - prev.Distance;
            }
        }
    }
}