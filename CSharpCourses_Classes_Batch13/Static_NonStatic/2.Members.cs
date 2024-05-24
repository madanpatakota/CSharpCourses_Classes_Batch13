using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticMembers
{
    // Static classes can only contain static members(methods, fields, properties),
    // while non-static classes can contain both static and non-static members.
    public static class EmployeeStaticLogger
    {
        private static int EmployeesList = 0;
        public static void PrintLogMessage(string message)
        {
            Console.WriteLine($"[Log] {message}");
            //EmployeesList++;
            EmployeesList = EmployeesList + 1;
        }
        public static int GetEmployeeListMessageCount()
        {
            return EmployeesList;
        }
    }

    public class EmployeeNonStaticLogger
    {
        private int EmployeesList = 0; // Instance member to count log messages
        public void PrintLogMessage(string message)
        {
            Console.WriteLine($"[Log] {message}");
            //EmployeesList++;
            EmployeesList = EmployeesList + 1;
        }
        public int GetEmployeeListMessageCount()
        {
            return EmployeesList;
        }

    }

    class Program
    {
        static void Main()
        {
            EmployeeStaticLogger.PrintLogMessage("Logged At 10-May");
            EmployeeStaticLogger.GetEmployeeListMessageCount();// 1

            EmployeeStaticLogger.PrintLogMessage("Logged At 11-May");
            EmployeeStaticLogger.GetEmployeeListMessageCount();// 2

            EmployeeStaticLogger.PrintLogMessage("Logged At 12-May");
            EmployeeStaticLogger.GetEmployeeListMessageCount();// 3

            EmployeeNonStaticLogger employeeNonStaticLogger = new EmployeeNonStaticLogger();
            employeeNonStaticLogger.PrintLogMessage("Logged At 10-May");
            employeeNonStaticLogger.GetEmployeeListMessageCount(); //1

            EmployeeNonStaticLogger employeeNonStaticLogger1 = new EmployeeNonStaticLogger();
            employeeNonStaticLogger1.PrintLogMessage("Logged At 11-May");
            employeeNonStaticLogger1.GetEmployeeListMessageCount(); //1

            EmployeeNonStaticLogger employeeNonStaticLogger2 = new EmployeeNonStaticLogger();
            employeeNonStaticLogger2.PrintLogMessage("Logged At 12-May");
            employeeNonStaticLogger2.GetEmployeeListMessageCount(); //1




            Console.ReadLine();


        }
    }


}
