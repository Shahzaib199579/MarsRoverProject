using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plateau : Rectangle
    {
        public Plateau()
        {
            Rovers = new List<Rover>();
        }
        public Plateau(Point bottomLeft, Point bottomRight, Point topLeft, Point topRight) : base(bottomLeft, bottomRight, topLeft, topRight)
        {
            Rovers = new List<Rover>();
        }

        public List<Rover> Rovers { get; set; }
    }
}
