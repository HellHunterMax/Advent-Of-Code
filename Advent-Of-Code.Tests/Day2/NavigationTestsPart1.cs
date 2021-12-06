using Advent_Of_Code.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day2
{
    public class NavigationTestsPart1
    {
        [Theory]
        [InlineData(new string[] { "forward 5", "down 5", "forward 8", "up 3", "down 8", "forward 2" }, 150)]
        public void NavigationGivenMoveInstructions_ReturnsPosition(string[] movements, int expected)
        {
            //Arrange
            NavigationPart1 navigation = new();

            //Act
            foreach (var movement in movements)
            {
                navigation.Move(movement);
            }

            //Assert
            Assert.Equal(expected, navigation.Position);
        }
    }
}
