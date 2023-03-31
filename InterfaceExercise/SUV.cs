using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool canOffRoad { get; set; }

        public int passengerCapacity { get; set; }

        public int numberOfWheels { get; set; }

        public string engineType { get; set; }

        public bool canDrive { get; set; }

        public string slogan { get; set; }

        public string name { get; set; }
    }
}
