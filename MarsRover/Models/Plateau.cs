using MarsRover.Miscellaneous;
using MarsRover.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plateau : Rectangle, ICreateService
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
            //foreach (var rover in Rovers)
            //{
            //    rover.ShowPosition();
            //}
            throw new NotImplementedException();
        }
    }
}
