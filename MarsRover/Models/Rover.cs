using MarsRover.Miscellaneous;
using MarsRover.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Rover : Vehicle, IMoveService
    {

        public Rover(): base()
        {
            
        }

        public Rover(Point position, char direction): base(position, direction)
        {
            
        }
        public string MoveRover(string command)
        {

            var tuple = DestinationCalculator.GetDestinationPointAndDirection(command, this.Position, this.Direction);

            this.Position = tuple.Item1;
            this.Direction = tuple.Item2;

            return this.CurrentPosition();
        }
    }
}
