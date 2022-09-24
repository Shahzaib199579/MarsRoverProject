using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Miscellaneous
{
    public static class RoverDirection
    {
        public const char NORTH = 'N';
        public const char SOUTTH = 'S';
        public const char EAST = 'E';
        public const char WEST = 'W';
    }

    public static class DirectionLinkedList
    {

        private static LinkedList<char>? _directions;

        public static LinkedList<char> Directions
        {
            get
            {
                char[] directions = new char[]
                {
                    RoverDirection.NORTH,
                    RoverDirection.EAST,
                    RoverDirection.SOUTTH,
                    RoverDirection.WEST
                };
                _directions = new LinkedList<char>(directions);
                return _directions;
            }
        }
    }

    public static class Commands
    {
        public const char MOVE_LEFT = 'L';
        public const char MOVE_RIGHT = 'R';
        public const char MOVE_FORWARD = 'M';
    }
}
