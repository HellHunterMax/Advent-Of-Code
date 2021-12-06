using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day3.Part1
{
    public class PowerPart1 : IPower
    {
        private string _gamma = String.Empty;
        private string _epsilon = String.Empty;


        public decimal ParseReport(List<string> report)
        {
            int halve = report.Count / 2;

            for (int i = 0; i < report[0].Length; i++)
            {
                int zeros = ReportParser.CountNumberOfZeros(report, i);
                int ZerosMore = ReportParser.ZerosMoreThanHalf(halve, zeros);
                AddGammaNumber(ZerosMore);
                AddEpsilonNumber(ZerosMore);

            }
            return CalculatePowerConsumption();
        }

        private void AddGammaNumber(int ZerosMore)
        {
            if (ZerosMore > 0)
            {
                _gamma += 0;
                return;
            }
            _gamma += 1;
        }
        private void AddEpsilonNumber(int ZerosMore)
        {
            if (ZerosMore > 0)
            {
                _epsilon += 1;
                return;
            }
            _epsilon += 0;
        }

        private decimal CalculatePowerConsumption()
        {
            return Convert.ToInt32(_gamma, 2) * Convert.ToInt32(_epsilon, 2);
        }

    }
}
