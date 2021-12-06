using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day3.Part1
{
    public class PowerPart1 : IPower
    {
        public decimal ParseReport(List<string> report)
        {
            string gamma = String.Empty;
            string epsilon = String.Empty;
            int halve = report.Count / 2;

            for (int i = 0; i < report[0].Length; i++)
            {
                int zeros = CountNumberOfZeros(report, i);
                AddBitsToGammaAndApsilon(ref gamma, ref epsilon, halve, zeros);
            }
            return CalculatePowerConsumption(gamma, epsilon);
        }

        private static decimal CalculatePowerConsumption(string gamma, string epsilon)
        {
            return Convert.ToInt32(gamma, 2) * Convert.ToInt32(epsilon, 2);
        }

        private static void AddBitsToGammaAndApsilon(ref string gamma, ref string epsilon, int halve, int zeros)
        {
            if (zeros > halve)
            {
                gamma += 0;
                epsilon += 1;
            }
            else
            {
                gamma += 1;
                epsilon += 0;
            }
        }

        private static int CountNumberOfZeros(List<string> report, int i)
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
