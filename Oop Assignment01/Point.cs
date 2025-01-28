using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Assignment01
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public double GetDistanceBetween(Point point)
        {
            double X_diff = (Math.Pow(point.X - X, 2));
            double Y_diff = (Math.Pow(point.Y - Y, 2));
            return Math.Sqrt(X_diff + Y_diff);

        }
    }
}
