using MarsRover.Miscellaneous;
using MarsRover.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plateau : Rectangle, ICreateService, IMoveService, IShowRoversService
    {
        public Plateau(): base()
        {
            Rovers = new List<Rover>();
            RoverPositions = new List<Point>();
        }
        public Plateau(Point topRight, Point bottomLeft) : base(topRight, bottomLeft)
        {
            Rovers = new List<Rover>();
            RoverPositions = new List<Point>();
        }

        protected List<Rover> Rovers { get; set; }
        protected List<Point> RoverPositions { get; set; }

        public int GetRoversCount()
        {
            return Rovers.Count;
        }

        private void AddRoverAndPosition(Rover rover, Point position)
        {
            Rovers.Add(rover);
            RoverPositions.Add(position);
        }

        private void RemoveRoverAndPosition(Rover rover, Point position)
        {
            Rovers.Remove(rover);
            RoverPositions.Remove(position);
        }

        public string CreateRover(int x, int y, char dir)
        {
            try
            {
                var position = new Point(x, y);
                if (RoverPositions.Where(r => r.X == position.X && r.Y == position.Y).ToList().Count != 0)
                    throw new Exception(ErrorMessages.ERROR + ": " + ErrorMessages.ROVER_EXIST_ON_POINT);
                var rover = new Rover(position, dir);
                AddRoverAndPosition(rover, position);
                return String.Empty;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }

        public void ShowRovers()
        {
            foreach (var rover in Rovers)
            {
                Console.WriteLine(rover.CurrentPosition());
            }
        }

        public string MoveRover(string command)
        {
            try
            {
                var rover = Rovers.Last();
                var destination = DestinationCalculator.GetDestinationPointAndDirection(command, 
                                                                                    rover.Position,
                                                                                    rover.Direction);
                if (RoverPositions.Where(x => x.X == destination.Item1.X 
                                            && x.Y == destination.Item1.Y).Count() > 0)
                {
                    throw new Exception(ErrorMessages.ERROR + ": " + ErrorMessages.ROVER_EXIST_ON_POINT);
                }

                RemoveRoverAndPosition(rover, rover.Position);

                rover.Position = destination.Item1;
                rover.Direction = destination.Item2;

                AddRoverAndPosition(rover, rover.Position);
                return Rovers.Last().CurrentPosition();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }
    }
}
