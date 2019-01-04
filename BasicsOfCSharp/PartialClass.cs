using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
  public partial  class PartialClass
    {
        public PartialClass()
        {
            Console.WriteLine("constructor of partial class");
        }
         static PartialClass()
        {
            Console.WriteLine("static constructor of partial class");
        }
        public void Method1()
        {
            Console.WriteLine("Partial class method1");
        }
        partial void PartialMethod();
        
    }
}


//Partial Class Requirements:
//All the partial class definitions must be in the same assembly and namespace.
//All the parts must have the same accessibility like public or private, etc.
//If any part is declared abstract, sealed or base type then the whole class is declared of the same type.
//Different parts can have different base types and so the final class will inherit all the base types.
//The Partial modifier can only appear immediately before the keywords class, struct, or interface.
//Nested partial types are allowed.
//Advantages of Partial Class
//Multiple developers can work simultaneously with a single class in separate files.
//When working with automatically generated source, code can be added to the class without having to recreate the source file.



//Points to Remember :
//Use the partial keyword to split interface, class, method or structure into multiple.cs files.
//The partial method must be declared before implementation.
//All the partial class, method , interface or structs must have the same access modifiers.