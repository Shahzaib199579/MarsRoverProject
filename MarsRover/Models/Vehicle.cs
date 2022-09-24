using MarsRover.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            Position = new();
            Direction = RoverDirection.NORTH;
        }

        public Vehicle(Point position, char direction)
        {
            Position = position;
            Direction = direction;
        }


        public Point Position { get; set; }
        public char Direction { get; set; }

        public virtual string CurrentPosition()
        {
            return Position.X.ToString() +" "+ Position.Y.ToString() +" "+ Direction.ToString();
        }
    }
}
