using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code.Day5
{
    public class Floor
    {
        //X = horizontal Y = vertical
        public List<List<int>> FloorPlan = new();

        public int NumberOfDangerousVents()
        {
            int count = 0;
            foreach (var y in FloorPlan)
            {
                foreach (var x in y)
                {
                    if (x > 1)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void AddVent(Point start, Point end)
        {
            if (DoesFloorPlanNeedEnlargement(start, end))
            {
                EnlargeFloorPlan(start, end);
            }

            List<Point> ventPoints = BuildVentPoints(start, end);

            foreach (Point point in ventPoints)
            {
                AddVentPoint(point);
            }
        }

        private void AddVentPoint(Point point)
        {
            FloorPlan[point.Y][point.X]++;
        }

        private List<Point> BuildVentPoints(Point start, Point end)
        {
            if (start.Y == end.Y)
            {
                return BuildHorizontalPoints(start, end);
            }
            if (start.X == end.X)
            {
                return BuildVerticalPoints(start, end);
            }
            return new List<Point>();
        }

        private List<Point> BuildVerticalPoints(Point start, Point end)
        {

            List<Point> points = new List<Point>();
            int y = end.Y;
            for (int x = start.X; x <= end.X; x++)
            {
                points.Add(new Point(x, y));
            }
            return points;
        }

        private List<Point> BuildHorizontalPoints(Point start, Point end)
        {
            List<Point> points = new List<Point>();
            int x = end.X;
            for (int y = start.Y; y <= end.Y; y++)
            {
                points.Add(new Point( x, y));
            }
            return points;
        }

        private bool DoesFloorPlanNeedEnlargement(params Point[] points)
        {
            int sizeFloorPlanNeeds = GetLargest(points);

            return FloorPlan.Count < sizeFloorPlanNeeds;
        }

        private void EnlargeFloorPlan(params Point[] points)
        {
            int newFloorPlanSize = GetLargest(points);
            
            for (int i = FloorPlan.Count; i < newFloorPlanSize; i++)
            {
                FloorPlan.Add(new List<int>());
            }
        }

        private int GetLargest(params Point[] points)
        {
            int largest = 0;
            foreach (var point in points)
            {
                largest = FindLargestPoint(largest, point);
            }
            return largest;
        }

        private static int FindLargestPoint(int largest, Point point)
        {
            if (point.X > largest)
            {
                largest = point.X;
            }
            if (point.Y > largest)
            {
                largest = point.Y;
            }

            return largest;
        }
    }
}
