using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day5
{
    public class Scanner
    {
        public readonly Floor Floor = new();

        public void BuildFloorPlan(string scanData)
        {
            const int start = 0;
            const int end = 1;
            
            var lines = File.ReadAllLines(scanData);

            List<Point[]> points = TurnLinesIntoPointPairs(lines);

            foreach (var pointStartAndEnd in points)
            {
                Floor.AddVent(pointStartAndEnd[start], pointStartAndEnd[end]);
            }
        }

        private List<Point[]> TurnLinesIntoPointPairs(string[] lines)
        {
            List<Point[]> points= new();

            foreach (var line in lines)
            {

                points.Add(ConvertToStartAndEndPoint(line));
            }

            return points;
        }

        // line looks like this: "0,9 -> 5,9"
        private static Point[] ConvertToStartAndEndPoint(string line)
        {
            string[] split = line.Split(' ');
            Point[] points = new Point[2];
            points[0] = ConvertToPoint(split[0]);
            points[1] = ConvertToPoint(split[2]);
            return points;
        }

        // XY looks like this: "5,9"
        private static Point ConvertToPoint(string XY)
        {
            string[] split = XY.Split(',');
            int x = int.Parse(split[0]);
            int y = int.Parse(split[1]);
            return new Point(x, y);
        }
    }
}
