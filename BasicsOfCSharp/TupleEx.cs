using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class TupleEx
    {
        Tuple<int, string, bool> t = new Tuple<int,string,bool>(1,"shashi",true);
       public TupleEx()
        {
            var t1 = Tuple.Create(2, "guru", false);
        }
        public void TupleAccessing()
        {
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
            Console.WriteLine(t.Item3);
        }
      public void TupleAsParameter(Tuple<int, string, string> person)
        {
            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");
        }
        public Tuple<int, string, string> TupleAsReturn()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }
    }
}


//Usage of Tuple
//Tuples can be used in the following scenarios:
//When you want to return multiple values from a method without using ref or out parameters.
//When you want to pass multiple values to a method through a single parameter.
//When you want to hold a database record or some values temporarily without creating a separate class.


//Tuple Limitations:
//Tuple is a reference type and not a value type.It allocates on heap and could result in CPU intensive operations.
//Tuple is limited to include 8 elements.You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
//Tuple elements can be accessed using properties with a name pattern Item<elementNumber> which does not make sense.