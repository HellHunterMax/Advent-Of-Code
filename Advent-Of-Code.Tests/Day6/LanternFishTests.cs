using Advent_Of_Code.Day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day6
{
    public class LanternFishTests
    {
        [Theory]
        [InlineData(18, 26)]
        [InlineData(80, 5934)]
        public void Count_After_AddXDays_Returns_NumberOfLanternFish(int days, int expected)
        {
            List<int> initialFish = new() { 3, 4, 3, 1, 2 };
            LanternFishScanner lanternFishScaner = new(initialFish);

            lanternFishScaner.AddDays(days);
            int actual = lanternFishScaner.FishCount();

            Assert.Equal(expected, actual);

        }
    }
}
