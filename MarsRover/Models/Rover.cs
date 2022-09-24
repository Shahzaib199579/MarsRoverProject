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
            var commandList = command.ToCharArray().ToList();
            var directions = DirectionLinkedList.Directions;
            foreach (var c in commandList)
            {
                var node = directions.Find(this.Direction);
                if (c.Equals(Commands.MOVE_LEFT))
                {
                    if (node.Previous != null)
                        this.Direction = node.Previous.Value;
                    else
                        this.Direction = directions.Last.Value;
                }
                if (c.Equals(Commands.MOVE_RIGHT))
                {
                    if (node.Next != null)
                        this.Direction = node.Next.Value;
                    else
                        this.Direction = directions.First.Value;
                }
                if (c.Equals(Commands.MOVE_FORWARD))
                {
                    if (this.Direction.Equals(RoverDirection.NORTH))
                        this.Position.Y = ++this.Position.Y;
                    if (this.Direction.Equals(RoverDirection.SOUTTH))
                        this.Position.Y = --this.Position.Y;
                    if (this.Direction.Equals(RoverDirection.WEST))
                        this.Position.X = --this.Position.X;
                    if (this.Direction.Equals(RoverDirection.EAST))
                        this.Position.X = ++this.Position.X;
                }
            }

            return this.CurrentPosition();
        }
    }
}
