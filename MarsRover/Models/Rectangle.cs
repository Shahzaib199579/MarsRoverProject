using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Rectangle: Shape
    {
        public Rectangle(): base()
        {
            BottomLeftPoint = SmallestPoint;
            TopRightPoint = GreatestPoint;
            TopLeftPoint = new();
            BottomRightPoint = new();
        }
        public Rectangle(Point bottomLeft, Point bottomRight, Point topLeft, Point topRight): base(topRight, bottomLeft)
        {
            BottomLeftPoint = bottomLeft;
            BottomRightPoint = bottomRight;
            TopLeftPoint = topLeft;
            TopRightPoint = topRight;
        }

        public Point BottomLeftPoint { get; set; }
        public Point BottomRightPoint { get; set; }
        public Point TopLeftPoint { get; set; }
        public Point TopRightPoint { get; set; }
    }
}
