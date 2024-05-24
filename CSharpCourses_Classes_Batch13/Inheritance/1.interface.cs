#region what is interface ?
/*
 * what is interface?
 * An interface in C# defines a contract specifying methods, properties, and events that implementing classes must provide, promoting code flexibility and polymorphic behavior.
 * 
 * 
 * If you refer the interface to the class then you should use the interface members
 * 
 */
#endregion


//{

//}

namespace InterfaceInitilizationStage
{
    interface ICompanyService
    {
        
        void EmployeesList();
         void EmployeeLocationsList();

    }

    interface IVehicleService
    {
        void Start();   // Method for starting the vehicle
        void Stop();    // Method for stopping the vehicle
    }


    //interface i1 : IVehicleService
    //{

    //}
}
