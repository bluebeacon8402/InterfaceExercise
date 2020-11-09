using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car: ICompany, IVehicle
    {
        public bool V6Engine { get; set; }
        public bool CylinderEngine {get; set;}
        public string Logo { get; set; }
        public string Name { get; set; }
        public int Wheels { get; set; }
        public bool Muffler { get; set; }
        public bool Radio { get; set; }
        public int Engines { get; set; }
    }
}
