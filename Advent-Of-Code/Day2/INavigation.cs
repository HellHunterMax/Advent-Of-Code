using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day2
{
    public interface INavigation
    {
        int Position { get;}
        void Move(string movement);
    }
}
