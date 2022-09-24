using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Point
    {
        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    
        public int X { get; set; }
        public int Y { get; set; }

        public void Print()
        {
            Console.Write("(" + X.ToString() + "," + Y.ToString() + ")");
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
        public static Point operator -(Point a, Point b)
        {
            return new Point(b.X - a.X, b.Y - a.Y);
        }
    }
}
