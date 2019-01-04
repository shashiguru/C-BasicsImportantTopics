using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class SortedListEx
    {
        public void SortedMetohd()
        {
            SortedList sortlist = new SortedList();
            sortlist.Add("LastName", "guru");
            sortlist.Add("FirstName", "Shashi");
            bool contains=sortlist.Contains("LastName");
            var keys = sortlist.Keys;
            var values = sortlist.Values;
            var valbyIndex = sortlist.GetByIndex(0);
            var key = sortlist.GetKey(1);

        }
    }
}


//Points to Remember :
//C# has generic and non-generic SortedList.
//SortedList stores the key-value pairs in ascending order of the key.Key must be unique and cannot be null whereas value can be null or duplicate.
//Non-generic SortedList stores keys and values of any data types. So values needs to be cast to appropriate data type.
//Key-value pair can be cast to DictionaryEntry.
//Access individual value using indexer. SortedList indexer accepts key to return value associated with it.
