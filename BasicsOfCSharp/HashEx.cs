using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class HashEx
    {
        
        public void HashMethod()
        {
            Hashtable hashTable = new Hashtable();
            Hashtable hashtable1 = new Hashtable();
            hashTable.Add("Name","Shashi");
            hashTable.Add("Company", "Accenture");
            hashTable.Add(1,"Name");
           var hashclone= hashTable.Clone();
            var val = hashTable["Company"];
            foreach (var item in hashTable.Keys)
            {
                var valforKey = hashTable[item];
                hashtable1.Add(item,valforKey);
            }
           var hashcode= hashTable.GetHashCode();
            var hashcode1 = hashtable1.GetHashCode();
            var compare = hashTable.Equals(hashTable);
        }
    }
}


//Points to Remember :
//Hashtable stores key-value pairs of any datatype where the Key must be unique.
//The Hashtable key cannot be null whereas the value can be null.
//Hashtable retrieves an item by comparing the hashcode of keys.So it is slower in performance than Dictionary collection.
//Hashtable uses the default hashcode provider which is object.GetHashCode(). You can also use a custom hashcode provider.
//Use DictionaryEntry with foreach statement to iterate Hashtable.