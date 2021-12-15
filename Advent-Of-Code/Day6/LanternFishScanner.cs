using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day6
{
    public class LanternFishScanner
    {
        private List<LanternFish> LanternFish = new();
        public int DayNumber { get; set; }


        public event EventHandler DayAdded;

        public long CountFish()
        {
            return LanternFish.Count;
        }

        public LanternFishScanner(IEnumerable<int> initialFish)
        {
            foreach (var fishAge in initialFish)
            {
                LanternFish fish = new LanternFish(fishAge);
                LanternFish.Add(fish);
                DayAdded += fish.OnDayAdded;
            }
        }

        public void AddDays(int days)
        {
            for (int i = 0; i < days; i++)
            {
                OnDayAdded();
                int length = LanternFish.Count;
                for (int x = 0; x < length; x++)
                {
                    if (LanternFish[x].TryProcreate(out var lanternFish))
                    {
                        LanternFish.Add(lanternFish);
                        DayAdded += lanternFish.OnDayAdded;
                    }
                }
            }
        }

        protected virtual void OnDayAdded()
        {
            if (DayAdded != null)
            {
                DayAdded(this, EventArgs.Empty);
            }
        }
    }
}
