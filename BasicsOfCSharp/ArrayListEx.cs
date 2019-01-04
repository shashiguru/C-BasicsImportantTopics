using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public class ArrayListEx
    {
        int[] intarr = new int[] { 1, 2, 3 };
        int[] copyarr=new int[5];
        int[] copyarr1=new int[5];
        int[] copyarr2= new int[5];
        public void ArrayListMethod()
        {
            ArrayList arr = new ArrayList();
            
            arr.Add("some");
            arr.Add(10);
            var count = arr.Count;
            bool fixedsize = arr.IsFixedSize;
            bool Readonly = arr.IsReadOnly;
            arr.AddRange(intarr);
            arr.Insert(1,50);
            arr.InsertRange(2,intarr);
            arr.RemoveRange(1, 2);
            arr.Remove(2);
            arr.RemoveAt(0);
            arr.Sort();
            arr.Reverse();
            var cap = arr.Capacity;
            var present = arr.Contains(10);
            //arr.CopyTo(copyarr);
            //arr.CopyTo(copyarr1, 1);
            //arr.CopyTo(0, copyarr2, 1, 3);

            
        }
        
    }
}


//Points to Remember :
//ArrayList can store items(elements) of any datatype.
//ArrayList resizes automatically as you add the elements.
//ArrayList values must be cast to appropriate data types before using it.
//ArrayList can contain multiple null and dulplicate items.
//ArrayList can be accessed using foreach or for loop or indexer.
//Use Add(), AddRange(), Remove(), RemoveRange(), Insert(), InsertRange(), Sort(), Reverse() methods.