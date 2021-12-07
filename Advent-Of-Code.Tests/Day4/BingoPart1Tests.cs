using Advent_Of_Code.Day4.Part1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Advent_Of_Code.Tests.Day4
{
    public class BingoPart1Tests
    {
        [Fact]
        public void GetWinner_GivenBingo_ReturnsWinner()
        {
            //Arrange
            Bingo bingo = new(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code.Tests\Day4\input\Bingo.txt");
            var expected = 4512;


            //Act
            var actual = bingo.FindWinner();

            //Assert.
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void GetLoser_GivenBingo_ReturnsLoser()
        {
            //Arrange
            Bingo bingo = new(@"C:\Code_Projects\2021\Advent-Of-Code\Advent-Of-Code\Advent-Of-Code.Tests\Day4\input\Bingo.txt");
            var expected = 1924;


            //Act
            var actual = bingo.FindLoser();

            //Assert.
            Assert.Equal(expected, actual);
        }
    }
}
