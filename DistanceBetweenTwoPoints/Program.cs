﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenTwoPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<double> point1 = new Point<double> (1.0, 2.0);
            Point<double> point2 = new Point<double> (4.0, 6.0);

            double distancePoints = point1.DistanceTo(point2);

            Console.WriteLine($"Distance between points is:{distancePoints}");
        }
    }
}