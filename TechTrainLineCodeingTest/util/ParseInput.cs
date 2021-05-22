using System;
using System.Collections.Generic;

namespace TechTrainLineCodeingTest
{
    public class ParseInput
    {
        public List<RunningLog> Parse()
        {
            var output = new List<RunningLog>();
            
            var first = new RunningLog(Console.ReadLine());
            if (first.Distance != 0) throw new ArgumentOutOfRangeException();
            output.Add(first);
            
            while (true)
            {
                var input = Console.ReadLine();
                if(input.Equals(String.Empty)) break;
                output.Add(new RunningLog(input));
            }

            return output;
        }
    }
}