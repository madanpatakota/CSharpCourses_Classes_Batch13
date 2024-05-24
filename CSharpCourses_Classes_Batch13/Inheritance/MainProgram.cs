using System;
using Companies;
using InterfaceInitilizationStage;

namespace ExecutionContext
{
     class MainProgram
    {
        static void Main()
        {
            ICompanyService softwareCompany = new SoftwareCompany();
            softwareCompany.EmployeesList();
            //softwareCompany.

            Console.ReadLine();

            //SoftwareCompany softwareCompany1 = new SoftwareCompany();
            //softwareCompany1.

        }
    }
}
