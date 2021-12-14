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

        /// <summary>
        /// </summary>
        /// <returns>The number of overlapping vents</returns>
        public int CountDangerousVents()
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

        /// <summary>
        /// Adds Vent places between the two points.
        /// </summary>
        /// <param name="start">start of the vent.</param>
        /// <param name="end">end of the vent.</param>
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
            //TODO refactor BuildVentPoints
            if (start.Y == end.Y)
            {
                if (start.X < end.X)
                {
                    return BuildVerticalPoints(start, end);
                }
                return BuildVerticalPoints(end, start);
            }
            if (start.X == end.X)
            {
                if (start.Y < end.Y)
                {
                    return BuildHorizontalPoints(start, end);
                }
                return BuildHorizontalPoints(end, start);
            }
            
            if (IsDiagonal(start, end))
            {
                return BuildDiagonalVents(start, end);
            }
            return new List<Point>();
        }

        private List<Point> BuildDiagonalVents(Point start, Point end)
        {
            //TODO BuildDiagonalVents
            // 1,1 3,3 && 9,7 7,9,
            List<Point> points = new();
            if (start.X < end.X && start.Y < end.Y)//RightDown
            {
                return BuildDiagonalRightDownPoints(start, end);
            }
            else if (start.X > end.X && start.Y > end.Y)//LeftUp
            {
                return BuildDiagonalRightDownPoints(end, start);
            }
            else if (start.X > end.X && start.Y < end.Y)//Going Left up
            {
                return BuildDiagonalRightUpPoints(end, start);
            }
            else if (start.X < end.X && start.Y > end.Y)//Going Right Up
            {
                return BuildDiagonalRightUpPoints(start, end);
            }
            return points;
        }

        private List<Point> BuildDiagonalRightUpPoints(Point start, Point end)
        {
            List<Point> points = new();
            int numberOfPoints = Math.Abs(start.X - end.X);
            for (int x = start.X, y = start.Y, i = 0; i <= numberOfPoints; x++, y--, i++)
            {
                points.Add(new Point(x, y));
            }
            return points;
        }

        private List<Point> BuildDiagonalRightDownPoints(Point start, Point end)
        {
            List<Point> points = new();
            int xx = Math.Abs(start.X - end.X);
            for (int x = start.X, y = start.Y, i = 0; i <= xx; x++, y++, i++)
            {
                points.Add(new Point(x, y));
            }
            return points;
        }

        private bool IsDiagonal(Point start, Point end)
        {
            int xx = Math.Abs(start.X - end.X);
            int yy = Math.Abs(start.Y - end.Y);
            return xx == yy;
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
                points.Add(new Point(x, y));

            }
            return points;
        }

        private bool DoesFloorPlanNeedEnlargement(params Point[] points)
        {
            int sizeFloorPlanNeeds = GetLargest(points);

            return FloorPlan.Count <= sizeFloorPlanNeeds;
        }

        private void EnlargeFloorPlan(params Point[] points)
        {
            int newFloorPlanSize = GetLargest(points);
            int ySize = FloorPlan.Count;

            for (int y = 0; y <= newFloorPlanSize; y++)
            {
                if (y >= ySize)
                {
                    FloorPlan.Add(new List<int>());
                }
                for (int x = FloorPlan[y].Count; x <= newFloorPlanSize; x++)
                {
                    FloorPlan[y].Add(0);
                }
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