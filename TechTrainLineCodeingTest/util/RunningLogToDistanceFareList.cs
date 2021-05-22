using System.Collections.Generic;

namespace TechTrainLineCodeingTest
{
    public class RunningLogToDistanceFareList
    {
        
        public static List<RunningDistance> Convert(List<RunningLog> runningLogs)
        {
            var output = new List<RunningDistance>();
            for (int i = 1; i < runningLogs.Count; i++)
            {
                output.Add(new RunningDistance(runningLogs[i-1],runningLogs[i]));
            }

            return output;
        }
    }
}