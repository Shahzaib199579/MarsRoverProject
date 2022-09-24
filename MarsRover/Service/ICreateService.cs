using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service
{
    public interface ICreateService
    {
        public string CreateRover(int x, int y, char dir);
    }
}
