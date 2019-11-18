using System;
using System.Collections.Generic;
using System.Text;

namespace StringAndStringBuilder
{
    public class StringBuilderTest
    {
        public void CompareStringToStringBuilder()
        {
            int size = 100;
            Timing timeSB = new Timing();
            Timing timeST = new Timing();

            for (int i = 0; i <= 3; i++)
            {
                timeSB.startTime();
                BuildSB(size);
                timeSB.StopTime();
                timeST.startTime();
                BuildString(size);
                timeST.StopTime();
                Console.WriteLine($"Time (in milliseconds) to build StringBuilder object for { size} elements: {timeSB.Result().TotalMilliseconds}");
                Console.WriteLine($"Time (in milliseconds) to build String object for { size} elements:  { timeSB.Result().TotalMilliseconds}");
                Console.WriteLine();
                size *= 10;
            }
        }
        private void BuildSB(int size)
        {
            StringBuilder sbObject = new StringBuilder();
            for (int i = 0; i <= size; i++)
            {
                sbObject.Append("a");
            }
        }
        private void BuildString(int size)
        {
            string stringObject = "";
            for (int i = 0; i <= size; i++)
            {
                stringObject += "a";
            }
        }
    }


}