using System.Collections.Generic;

namespace TechTrainLineCodeingTest
{
    public class RunningLogToSpeedFareList
    {
        public static List<RunningSpeed> Convert(List<RunningLog> runningLogs)
        {
            var output = new List<RunningSpeed>();
            for (int i = 1; i < runningLogs.Count; i++)
            {
                output.Add(new RunningSpeed(runningLogs[i-1],runningLogs[i]));
            }

            return output;
        }
    }
}