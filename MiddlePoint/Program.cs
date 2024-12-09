using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddlePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> point1 = new Point<double>(2, 4);
            Point<double> point2 = new Point<double>(6, 8);

            Point<double> middlePoint = Point<double>.Midpoint(point1, point2);

            Console.WriteLine($"The middle point is:({middlePoint.X}, {middlePoint.Y})");
        }
    }
}
