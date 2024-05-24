using System;
using System.Linq;
using InterfaceInitilizationStage;

namespace Companies
{
    class SoftwareCompany : ICompanyService
    {
        public void EmployeesList()
        {
           // string str = "hellow world";
            string[] employeeNames = { "John", "Peter" , "Robert"};
            Console.WriteLine($"EmployeesList Count {employeeNames.Length}"); //3
        }
        public void EmployeeLocationsList()
        {
            string location = "NewYork";
            Console.WriteLine($"{location}");
        }

        //Additional :  i want to get the ProjectNamesList
        //public string GetProjectNamesList()
        //{
        //    return "John";
        //}
        public string[] GetProjectNamesList()
        {
            string[] projectNames = { "TCS-Project", "Infosis-Project" };
            return projectNames;
        }
    }
}
