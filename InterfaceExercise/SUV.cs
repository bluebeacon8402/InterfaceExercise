using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV: ICompany, IVehicle
    {
        public bool Armor { get; set; }
        public bool AllWheel { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }
        public bool Muffler { get; set; }
        public bool Radio { get; set; }
        public int Engines { get; set; }
    }
}
