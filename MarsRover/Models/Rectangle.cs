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
            TopLeftPoint = new Point(SmallestPoint.X, GreatestPoint.Y);
            BottomRightPoint = new Point(GreatestPoint.X, SmallestPoint.Y);
        }
        public Rectangle(Point topRight, Point bottomLeft): base(topRight, bottomLeft)
        {
            BottomLeftPoint = bottomLeft;
            TopRightPoint = topRight;
            BottomRightPoint = new Point(GreatestPoint.X, SmallestPoint.Y);
            TopLeftPoint = new Point(SmallestPoint.X, GreatestPoint.Y);
        }

        public Point BottomLeftPoint { get; set; }
        public Point BottomRightPoint { get; set; }
        public Point TopLeftPoint { get; set; }
        public Point TopRightPoint { get; set; }
    }
}
