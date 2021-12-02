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
            int? lastMeasurement = null;
            int increases = 0;

            foreach (var measurement in measurements)
            {
                if (lastMeasurement != null && lastMeasurement < measurement) increases++;
                lastMeasurement = measurement;
            }

            return increases;
        }
    }
}
