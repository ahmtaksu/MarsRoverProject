using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Objects;

namespace MarsRover.Interfaces
{
    interface IRover
    {
        Location location { get; set; }
        Surface surface { get; set; }

        void Action(string actions);
        void TakeAction(char actions);
        void TurnLeft();
        void TurnRight();
    }
}
