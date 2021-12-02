using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day1
{
    public class DepthIncreaseMeasurer
    {
        public static int Measure(IEnumerable<int> measurements)
        {
            int increases = 0;
            List<int> measurementsList = measurements.ToList();

            for (int i = 3; i < measurementsList.Count; i++)
            {
                if (measurementsList[i] > measurementsList[i - 3])
                {
                    increases++;
                }
            }

            return increases;
        }
    }
}
