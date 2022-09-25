using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Miscellaneous
{
    public static class DestinationCalculator
    {
        public static Tuple<Point, char> GetDestinationPointAndDirection(string command,
                                                                Point currentPosition,
                                                                char direction)
        {
            var commandList = command.ToCharArray().ToList();
            var directions = DirectionLinkedList.Directions;
            var positionCopy = new Point(currentPosition.X, currentPosition.Y);
            var directionCopy = direction;
            foreach (var c in commandList)
            {
                var node = directions.Find(directionCopy);
                if (c.Equals(Commands.MOVE_LEFT))
                {
                    if (node.Previous != null)
                        directionCopy = node.Previous.Value;
                    else
                        directionCopy = directions.Last.Value;
                }
                if (c.Equals(Commands.MOVE_RIGHT))
                {
                    if (node.Next != null)
                        directionCopy = node.Next.Value;
                    else
                        directionCopy = directions.First.Value;
                }
                if (c.Equals(Commands.MOVE_FORWARD))
                {
                    if (directionCopy.Equals(RoverDirection.NORTH))
                        positionCopy.Y = ++positionCopy.Y;
                    if (directionCopy.Equals(RoverDirection.SOUTTH))
                        positionCopy.Y = --positionCopy.Y;
                    if (directionCopy.Equals(RoverDirection.WEST))
                        positionCopy.X = --positionCopy.X;
                    if (directionCopy.Equals(RoverDirection.EAST))
                        positionCopy.X = ++positionCopy.X;
                }
            }

            return new Tuple<Point, char>(positionCopy, directionCopy);
        }
    }
}
