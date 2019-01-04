using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public class ValueTypeTuple
    {
        ValueTuple<int, string, bool> v = (1,"shashi",true);
        public void CreateValueTuple()
        {
            var v1 = (1,"shashi","guru");
            (int, string, char) v2 = (1,"guru",'g');
            var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14); //Unlike Tuple, a ValueTuple can include more than eight values.
            (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
            var person1 = (Id: 1, FirstName: "shashi", LastName: "guru");
        }
        public (int,string,string) ValueTupleAsReturn()
        {
            return (1, "shashi", "guru");
        }
    }
}
