using Advent_Of_Code.Day6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day6
{
    public class LanternFishHackTests
    {
        [Theory]
        [InlineData(18, 26)]
        [InlineData(80, 5934)]
        [InlineData(256, 26984457539)]
        public void Count_After_AddXDays_Returns_NumberOfLanternFish(int days, long expected)
        {
            List<int> initialFish = new() { 3, 4, 3, 1, 2 };
            LanternFishHack lanternFishScaner = new(initialFish);

            lanternFishScaner.AddDays(days);
            var actual = lanternFishScaner.CountFish();

            Assert.Equal(expected, actual);

        }
    }
}
