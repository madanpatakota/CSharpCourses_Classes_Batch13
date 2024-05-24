using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * // Static class
// Static classes cannot be instantiated with the new keyword,
// whereas non-static classes can be instantiated to create objects.

  All members in static class should the static members

 */

namespace StaticAndNonStaticInstatiate
{
    static class StaticClass
    {
       //  member ? What type of member should be in static class ?
       // Every member(method , property or constructor) should be static 
       public static void PrintMessage()
        {
            Console.WriteLine("This is a static class method.");
        }

    }

    class NonStaticClass
    {
       public void PrintMessage()
        {
            Console.WriteLine("This is a non-static class method.");
        }

    }

    class Program
    {
        static void Main()
        {
            // Static class usage
            // Static classes cannot be instantiated, so we call the method directly using the class name.
            StaticClass.PrintMessage();

            // Non-static class usage
            // Non-static classes can be instantiated, so we create an instance of the class and then call the method.
            NonStaticClass nonStaticClass = new NonStaticClass();
            nonStaticClass.PrintMessage();


        }
    }


    
}
