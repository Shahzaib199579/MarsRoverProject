using MarsRover.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class MissionControl: IMoveService, ICreateService, IShowRoversService
    {
        public MissionControl()
        {
            MissionPlateu = new();
        }

        public MissionControl(Point topRight, Point bottomLeft)
        {
            MissionPlateu = new(topRight, bottomLeft);
        }
        public Plateau MissionPlateu { get; set; }

        public string CreateRover(int x, int y, char dir)
        {
            var result = MissionPlateu.CreateRover(x, y, dir);
            return result;
        }

        public string MoveRover(string command)
        {
            var result = MissionPlateu.MoveRover(command);
            return result;
        }

        public void ShowRovers()
        {
            MissionPlateu.ShowRovers();
        }
    }
}
