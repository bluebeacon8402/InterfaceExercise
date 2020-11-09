using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck: ICompany, IVehicle
    {
        public int Beds { get; set; }

        public bool BigTires { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }
        public bool Muffler { get; set; }
        public bool Radio { get; set; }
        public int Engines { get; set; }
    }
}
