using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int numberOfWheels { get; set; }

        public string engineType { get; set; }

        public bool canDrive { get; set; }
       
        public string slogan { get; set; }

        public string name { get; set; }

        public bool hasFourWheelDrive { get; set; }

        public string truckBedSize { get; set; }

    }
}
