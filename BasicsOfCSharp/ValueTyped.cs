using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class ValueTyped
    {
        //value type field in a class can be declared without initialization
        //It will have a default value if not assigned any value, e.g., int will have 0, boolean will have false and so on.
        public int j;
        public void someFunction()
        {
            int i;
            //value type variables must be assigned some value before use.
            //The compiler will give an error if you try to use a local value type variable without assigning a value to it.
            //Console.WriteLine(i);
        }
    }
}
