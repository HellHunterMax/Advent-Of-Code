using Advent_Of_Code.Day2;
using Advent_Of_Code.Day3;
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
        private readonly INavigation _navigation;
        private readonly IPower _power;

        public Submarine(Sonar sonar, INavigation navigation, IPower power)
        {
            _sonar = sonar;
            _navigation = navigation;
            _power = power;
        }

        public void PowerConsumption(string file)
        {
            var report = File.ReadAllLines(file);

            var powerConsumption = _power.ParseReport(report.ToList());

            Console.WriteLine(powerConsumption);
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
