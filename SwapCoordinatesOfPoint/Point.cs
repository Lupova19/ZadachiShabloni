using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapCoordinatesOfPoint
{
    public class Point<T>
    {
        private T x, y;

        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Swap()
        {
            T swap;
            swap = x;
            x = y;
            y = swap;
        }
        public void Print()
        {
            Console.WriteLine($"Swap point:({this.X}, {this.Y})");
        }
    }
}
