using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class MainClass
    {
        static void Main(string[] args)
        {
            EmptyClass obj = new EmptyClass();
            GetMemorySize(obj);
            ValueTyped obj1 = new ValueTyped();
            Console.WriteLine(obj1.j);
            Console.WriteLine(AnonymousType.AnonymousMethod());
            IInterfaceTopics i1 = new ImplementingInterface();
            i1.DoSome();
            IInterfaceTopics i2 = new AnotherImplemetation();
            i2.DoSome();
            IInterfaceTopics i3 = new ExplicitlyImplementation();
            i3.DoSome();
            //tructure object without using new keyword
            StructExample s1;
            s1.EmpId = 10;
            Console.WriteLine(s1.EmpId);
            //tructure object with using new keyword
            StructExample s2 = new StructExample(1,"shashi","guru");
            Console.WriteLine(s2.EmpId);
            Console.WriteLine(s2.FirstName);
            Console.WriteLine(s2.LastName);
            Console.ReadLine();

        }
        public static void GetMemorySize(object obj)
        {
            using (Stream s = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(s, obj);
                Console.WriteLine("object size");
                Console.WriteLine(s.Length);
            }
        }
    }
}
