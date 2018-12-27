using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public static class AnonymousType
    {
        public static object AnonymousMethod()
        {
            //An anonymous type is a temporary data type that is inferred based on the data that you include in an object initializer. 
            //Properties of anonymous types will be read - only properties so you cannot change their values.
            //The implicitly typed variable-var, is used to hold an anonymous type.
             var Anonymous =  new
            {
                id = 1,
                name="guru",
            };
            Console.WriteLine(Anonymous.id);
            Console.WriteLine(Anonymous.name);
            //checking the type of an anonymous type
            Console.WriteLine(Anonymous.GetType().ToString());
            //An anonymous type will always be local to the method where it is defined.Usually, you cannot pass an anonymus type to another method; 
            //however, you can pass it to a method that accepts a parameter of dynamic type.
            CallingMethodAnonymous(Anonymous);
            return Anonymous;
        }

        //Please note that Passing anonymous types using dynamic is not recommended.
        public static void CallingMethodAnonymous(dynamic anonymous)
        {
            Console.WriteLine(anonymous.name);
        }
    }
}




//Points to Remember :
//Anonymous type can be defined using the new keyword and object initializer syntax.
//The implicitly typed variable- var, is used to hold an anonymous type.
//Anonymous type is a reference type and all the properties are read-only.
//The scope of an anonymous type is local to the method where it is defined.