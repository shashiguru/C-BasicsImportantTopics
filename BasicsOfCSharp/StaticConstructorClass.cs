using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class StaticConstructorClass
    {
       static StaticConstructorClass()
        {
            Console.WriteLine("Static constructor in non static class");
        }
        public StaticConstructorClass()
        {
            Console.WriteLine("default or non static constructor");
        }
    }
   public static class WithStatic
    {
        static WithStatic()
        {
            Console.WriteLine("Static constructor in static class");
        }
        //static classes will not have default or non static constructor
        //public WithStatic()
        //{
        //    Console.WriteLine("");
        //}
        public static void somemethod()
        {
            Console.WriteLine("some method of with static class");
        }

    }
}


//Points to Remember :
//Static classes cannot be instantiated using the new keyword
//Static items can only access other static items.For example, a static class can only contain static members, e.g., variables, methods, etc.A static method can only contain static variables and can only access other static items.
//Static items share the resources between multiple users.
//Static cannot be used with indexers, destructors or types other than classes.
//A static constructor in a non-static class runs only once when the class is instantiated for the first time.
//A static constructor in a static class runs only once when any of its static members accessed for the first time.
//Static members are allocated in high frequency heap area of the memory.