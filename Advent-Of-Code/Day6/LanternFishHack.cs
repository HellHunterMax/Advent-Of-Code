using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day6
{
    public class LanternFishHack
    {
        Dictionary<int, long> Fish = new()
        {
            {-1, 0},
            { 0, 0},
            { 1, 0},
            { 2, 0},
            { 3, 0},
            { 4, 0},
            { 5, 0},
            { 6, 0},
            { 7, 0},
            { 8, 0}
        };

        public LanternFishHack(IEnumerable<int> initial)
        {
            foreach (var number in initial)
            {
                Fish[number]++;
            }
        }

        public long CountFish()
        {
            long count = 0;
            foreach (var age in Fish)
            {
                count += age.Value;
            }
            return count;
        }

        public void AddDays(int days)
        {
            for (int i = 0; i < days; i++)
            {
                AgeFish();
                ProcreateFish();
            }
        }

        private void ProcreateFish()
        {
            Fish[8] = Fish[-1];
            Fish[6] += Fish[-1];
            Fish[-1] = (long)0;
        }

        private void AgeFish()
        {
            for (int age = -1; age < 8; age++)
            {
                Fish[age] = Fish[age + 1];
            }
        }
    }
}
