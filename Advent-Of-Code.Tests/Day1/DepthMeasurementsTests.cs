using Advent_Of_Code.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day1
{
    public class DepthMeasurementsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 3)]
        [InlineData(new int[] { 199,200,208,210,200,207,240,269,260,263}, 7)]
        [InlineData(new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0}, 0)]
        public void DepthMasurements_GivenMeasurements_ReturnsIncreaseAmount(IEnumerable<int> measurements, int expected)
        {
            //Arrange
            //Act
            var depthIncrease = DepthIncreaseMeasurer.Measure(measurements);

            //Assert
            Assert.Equal(expected, depthIncrease);
        }
    }
}
