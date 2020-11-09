using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public int Wheels { get; set; }
        public bool Muffler { get; set; }
        public bool Radio { get; set; }
        public int Engines { get; set; }

    }
}
