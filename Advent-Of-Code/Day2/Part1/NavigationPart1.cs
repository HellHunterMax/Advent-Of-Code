using Advent_Of_Code.Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day2
{
    public class NavigationPart1 : INavigation
    {
        public int Position { get { return Horizontal * Vertical; } }
        private int Horizontal { get; set; }
        private int Vertical { get; set; }
        private const char horizontalChar = 'h';
        private const char verticalChar = 'v';
        private const int directionNumber = 0;
        private const int distanceNumber = 1;
        private const string up = "up";
        private const string down = "down";
        private const string forward = "forward";

        private void SetMove(char v, int distance)
        {
            switch (v)
            {
                case horizontalChar:
                    Horizontal += distance;
                    break;
                case verticalChar:
                    Vertical += distance;
                    break;
                default:
                    break;
            }
        }

        public void Move(string movement)
        {
            var splitMovement = movement.Split(' ');

            int distance = ParseDistance(splitMovement);
            char movementDirection = ParseDirection(directionNumber,ref distance, splitMovement);

            SetMove(movementDirection, distance);
        }

        private static int ParseDistance(string[] splitMovement)
        {
            if (!int.TryParse(splitMovement[distanceNumber], out int distance))
            {
                throw new Exception($"Distance \"{splitMovement[distanceNumber]}\" Could not be parsed!");
            }

            return distance;
        }

        private static char ParseDirection(int directionNumber,ref int distance, string[] splitMovement)
        {
            char movementDirection;
            switch (splitMovement[directionNumber])
            {
                case up:
                    movementDirection = verticalChar;
                    distance = 0 - distance;
                    break;
                case down:
                    movementDirection = verticalChar;
                    break;
                case forward:
                    movementDirection = horizontalChar;
                    break;
                default:
                    throw new Exception($"Direction \"{splitMovement[directionNumber]}\" could not be parsed");
            }

            return movementDirection;
        }
    }
}
