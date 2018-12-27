using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    //a value type entity same as class called "structure". Structs are mainly useful to hold small data values.
    struct StructExample:IInterfaceTopics
    {
        
        public int EmpId;
        public string FirstName;
        public string LastName;
        //A struct cannot contain parameterless constructor.It can only contain parameterized constructors or a static constructor.
        //    You can declare parameterized constructor to initialize struct members
       public StructExample(int empid, string fname, string lname)
        {
            EmpId = empid;
            FirstName = fname;
            LastName = lname;
        }

        static StructExample()
        {
            Console.WriteLine("Constructor with static");
        }
        public void somemethod()
        {
            Console.WriteLine();

        }
        //Structure can implement interfaces, same as class.
        public void DoSome()
        {
            Console.WriteLine("struct implemented interface");
        }
        
    }
}


//Characteristics of Structure:
//Structure can include constructors, constants, fields, methods, properties, indexers, operators, events & nested types.
//Structure cannot include parameterless constructor or destructor.
//Structure can implement interfaces, same as class.
//A structure cannot inherit another structure or class, and it cannot be the base of a class.
//Structure members cannot be specified as abstract, virtual, or protected.




//Difference between Struct and Class:
//Class is reference type whereas struct is value type
//Struct cannot declare a default constructor or destructor.However, it can have parametrized constructors.
//Struct can be instasntiated without the new operator. However, you won't be able to use any of its methods, events or properties if you do so.
//Struct cannot be used as a base or cannot derive another struct or class.