using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Shape
    {
        public Shape()
        {
            GreatestPoint = new();
            SmallestPoint = new();
        }

        public Shape(Point greatestPoint, Point smallestPoint)
        {
            GreatestPoint = greatestPoint;
            SmallestPoint = smallestPoint;
        }
        public Point GreatestPoint { get; set; }
        public Point SmallestPoint { get; set; }
    }
}
