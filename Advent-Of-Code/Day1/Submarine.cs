using Advent_Of_Code.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day1
{
    public class Submarine
    {
        private readonly Sonar _sonar;
        private readonly Navigation _navigation;

        public Submarine(Sonar sonar,Navigation navigation)
        {
            _sonar = sonar;
            _navigation = navigation;
        }

        public void Move(string file)
        {
            var movements = File.ReadAllLines(file);
            foreach (var movement in movements)
            {
                _navigation.Move(movement);
            }
            Console.WriteLine(_navigation.Position);
        }

        public void PrintDepthIncrease()
        {
            Console.WriteLine(_sonar.GetDepthIncrease());
        }
    }
}
