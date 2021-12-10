using Advent_Of_Code.Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day5
{
    public class HydrothermalVentureTests
    {
        [Fact]
        public void ScannerFloorCountDangerousVents_GivenFloorPlan_ReturnsNumberOFDangerousVents()
        {
            Scanner scanner = new Scanner();
            const int expected = 5;

            scanner.BuildFloorPlan(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code.Tests\Day5\input\Vents.txt");
            var actual = scanner.Floor.CountDangerousVents();

            Assert.Equal(expected, actual);
        }
    }
}
