using System;
using System.Collections.Generic;

namespace TechTrainLineCodeingTest
{
    public class ParseInput
    {
        public List<RunningLog> Parse()
        {
            var strings = new List<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if(input.Equals(String.Empty)) break;
                strings.Add(input);
            }

            var output = new List<RunningLog>();

            foreach (var str in strings)
            {
                output.Add(new RunningLog(str));
            }

            return output;
        }
    }
}