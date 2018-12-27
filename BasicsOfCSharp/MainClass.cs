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
