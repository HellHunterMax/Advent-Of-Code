using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day3
{
    public static class ReportParser
    {

        public static int ZerosMoreThanHalf(int halve, int zeros)
        {
            if (zeros > halve)
            {
                return 1;
            }
            else if (zeros < halve)
            {
                return -1;
            }
            return 0;
        }

        public static int CountNumberOfZeros(List<string> report, int i)
        {
            int zeros = 0;

            for (int j = 0; j < report.Count; j++)
            {
                if (report[j][i] == '0')
                {
                    zeros++;
                }
            }

            return zeros;
        }
    }
}
