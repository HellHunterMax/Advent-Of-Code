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

        public Submarine(Sonar sonar)
        {
            _sonar = sonar;
        }

        public void PrintDepthIncrease()
        {
            Console.WriteLine(_sonar.GetDepthIncrease());
        }
    }
}
