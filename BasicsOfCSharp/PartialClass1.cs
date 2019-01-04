using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public partial class PartialClass
    {
        public void Method2()
        {
            Console.WriteLine("Method2 of Partial class");
        }
        partial void PartialMethod()
        {
            Console.WriteLine("Parial method of Partial class");
        }
    }
}


//Requirements for Partial Method
//The partial method declaration must began with the partial modifier.
//The partial method can have a ref but not an out parameter.
//Partial methods are implicitly private methods so we cant call partial method from different class.
//Partial methods can be static methods.
//Partial methods can be generic.
