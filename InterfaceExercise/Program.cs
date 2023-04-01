using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car malibu = new Car();

            malibu.canDrive = true;
            malibu.size = "mid size";
            malibu.engineType = "V6";
            malibu.numberOfWheels = 4;
            malibu.slogan = "The family car";
            malibu.hasTrunk = true;

            Truck sierra = new Truck();

            sierra.engineType = "5.3L V8";
            sierra.numberOfWheels = 4;
            sierra.canDrive = true;
            sierra.truckBedSize = "5 feet";
            sierra.hasFourWheelDrive = true;

            SUV explorer= new SUV();

            explorer.canOffRoad = true;
            explorer.canDrive = true;
            explorer.passengerCapacity = 5;
            explorer.slogan = "Built Ford Tough";
            explorer.engineType = "V6";

            Console.WriteLine("Hi! I have three vehicles and I want you to guess what vehicle matches the description!");

            
            //VEHICLE 1
            Console.WriteLine("Let's start with vehicle number 1!");

            Console.WriteLine($"It's size is considered {malibu.size}");

            Console.WriteLine($"It has this engine type {malibu.engineType}");

            Console.WriteLine($"It's slogan is {malibu.slogan}");

            Console.WriteLine($"Does it have a trunk? - {malibu.hasTrunk}");


            //VEHICLE 2
            Console.WriteLine("Moving on to vehicle number 2!");

            Console.WriteLine($"It has this engine type {sierra.engineType}");

            Console.WriteLine($"It's truck bed size is - {sierra.truckBedSize}");

            Console.WriteLine($"Does it have four wheel drive? {sierra.hasFourWheelDrive}");


            //Vehicle 3
            Console.WriteLine("And here is the info on the 3rd and final vehicle");

            Console.WriteLine($"It has this engine type {explorer.engineType}");

            Console.WriteLine($"Can it off road? {explorer.canOffRoad}");

            Console.WriteLine($"It can have this many passengers - {explorer.passengerCapacity}");

            Console.WriteLine($"It's slogan is {explorer.slogan}");

            
            
            Console.WriteLine("And that is it. Here are the options so think about what vehicle you match to each option. There is a malibu, a sierra, and an explorer!");




        }
    }
}
