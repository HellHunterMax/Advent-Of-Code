using Advent_Of_Code.Day3.Part1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day3
{
    public class PowerTestsPart1
    {
        [Theory]
        [InlineData(new string[] { "00100", "11110", "10110", "10111", "10101", "01111", "00111", "11100", "10000", "11001", "00010", "01010" }, 198)]
        public void CalculatePowerConsumtion_GivenBinary_ReturnsConsumption(string[] report, int expected)
        {
            PowerPart1 power = new();

            var actualConsumption = power.ParseReport(report.ToList());

            Assert.Equal(expected, actualConsumption);
        }
    }
}
