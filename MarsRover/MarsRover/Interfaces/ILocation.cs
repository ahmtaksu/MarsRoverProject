using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Interfaces
{
    interface ILocation
    {
        int axisX { get; set; }
        int axisY { get; set; }
        char direction { get; set; }

        void CheckIfDirectionAvailable(char direction);
    }
}
