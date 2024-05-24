using System;
using InterfaceInitilizationStage;

namespace MultipleInterfaceInitStage
{
    //class abc : Car { }

    class Car : IVehicleService
    {
       public void Start()
        {
            Console.WriteLine("Car is starting.");
        }  
       public void Stop()
        {
            Console.WriteLine("Car is Stopping.");
        }

    }

    class Bike : IVehicleService
    {
        public void Start()
        {
            Console.WriteLine("Bike is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("Bike is Stopping.");
        }
    }


}























