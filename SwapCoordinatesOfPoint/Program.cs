using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapCoordinatesOfPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>(3, 4);
            point.Swap();
            point.Print();
        }

       
    }
}
