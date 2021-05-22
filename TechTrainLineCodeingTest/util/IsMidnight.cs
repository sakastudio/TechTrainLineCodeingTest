namespace TechTrainLineCodeingTest
{
    public class IsMidnight
    {
        public static bool Judg(RunningLog prev, RunningLog next)
        {
            var prevHour = prev.Hour % 24;
            var nextHour = next.Hour % 24;
            
            if (22 <= prevHour && nextHour <= 23)
            {
                return true;
            }else if (0 <= prevHour && nextHour <= 4)
            {
                return true;
            }

            return false;
        }
    }
}