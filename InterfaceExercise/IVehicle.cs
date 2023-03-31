using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        public int numberOfWheels { get; set; }

        public string engineType { get; set; }

        public bool canDrive { get; set; }

        public void TurnLightsOn()
        {
            Console.WriteLine("Lights are on");
        }
    }
}
