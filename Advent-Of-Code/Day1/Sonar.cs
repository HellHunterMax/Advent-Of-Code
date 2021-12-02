using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day1
{
    public class Sonar
    {
        public List<int> LastReport { get; private set; } = new List<int>();

        public int GetDepthIncrease()
        {
            Sweep(@"Input\depths.txt");
            return DepthIncreaseMeasurer.Measure(LastReport);
        }

        private void Sweep(string inputFile)
        {
            LastReport = new List<int>();
            var textFile = File.ReadAllLines(inputFile);
            foreach (var line in textFile)
            {
                if (int.TryParse(line, out int result)) LastReport.Add(result);
            }
        }
    }
}
