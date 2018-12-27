using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    /// <summary>
    /// var(Implicit Typed Local Variable)  can only be defined in a method as a local variable.
    /// </summary>
    //var c="a";
    public class ImpBasics
    {
        public void ImplicitlytypedMethod()
        {
            //Implicitly - typed variables must initialized at the time of declaration, otherwise C# compiler would give an error: Implicitly-typed variables must be initialized.
            //ex: var a; // Compile-time error: Implicitly-typed variables must be initialized
            var b = 100;
        }
        /// <summary>
        /// var cannot be used for function parameters.
        /// </summary>
        //void Display(var param) //Compile-time error
        //{
        //    Console.Write(param);
        //}

        //explicit conversion
        public static void ExplicitConversion()
        {
            int i = 100;
            uint u = (uint)i;
            Console.Write(i);
        }
    }
    //empty class cannot be serialized, it will throw exception thats the reason class should be serialized.
    //we can create object for empty class and this object can take memory(approx 132kb)
    [Serializable]
    public class EmptyClass
    {

    }
}



//Points to Remember :
//var can only be declared and initialized in a single statement.Following is not valid: 
//var i; i = 10;
//var cannot be used as a field type at the class level.
//var cannot be used in an expression like var i += 10;
//Multiple vars cannot be declared and initialized in a single statement.For example, var i=10, j=20; is invalid