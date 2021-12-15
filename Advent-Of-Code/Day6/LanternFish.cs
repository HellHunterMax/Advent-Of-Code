using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day6
{
    public class LanternFish
    {
        public int Age { get; private set; }
        private bool Pregnant { get; set; } = false;

        public LanternFish(int age = 8)
        {
            Age = age;
        }

        public void OnDayAdded(object source, EventArgs args)
        {
            AddDay();
        }

        private void AddDay()
        {
            Age--;
            if (Age == -1)
            {
                Pregnant = true;
                Age = 6;
            }
        }

       public bool TryProcreate(out LanternFish lanternFish)
        {
            lanternFish = new();
            if (Pregnant)
            {
                Pregnant = false;
                return true;
            }
            return false;
        }
    }
}
