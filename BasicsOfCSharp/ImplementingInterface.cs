using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public class ImplementingInterface:IInterfaceTopics
    {
        public void DoSome()
        {
            Console.WriteLine("Some implementation"); 
        }

    }
    public class AnotherImplemetation:IInterfaceTopics
    {
        public void DoSome()
        {
            Console.WriteLine("Some Another implementation");
        }
    }


    //Explicit implementation is useful when class is implementing multiple interface thereby it is more readable and eliminates the confusion.
    //It is also useful if interfaces have same method name coincidently.
    public class ExplicitlyImplementation:IInterfaceTopics
    {
         void IInterfaceTopics.DoSome()
        {
            Console.WriteLine("explicitly implementation");
        }
    }
}




