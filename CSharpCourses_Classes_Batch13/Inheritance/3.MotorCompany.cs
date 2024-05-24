using System;
using InterfaceInitilizationStage;

namespace MotorVehicles
{
    class MotorsCompany : ICompanyService
    {
        public void EmployeesList()
        {
            Console.WriteLine("Employees List is available i.e. 100 ");
        }
        public void EmployeeLocationsList()
        {
            Console.WriteLine("Location is available i.e. Hyderabad ");
        }
    }
}
