using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
  public static class StaticClass
    {
        public static string StaticVariable;
        public static void StaticMethod()
        {
            Console.WriteLine("Static Method");
            StaticVariable = "this is static variable";
        }

    }
}
