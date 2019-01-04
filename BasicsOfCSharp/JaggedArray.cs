using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    public class JaggedArray
    {
        public int[][] jagged = new int[2][]
        {
            new int[3]{1,2,3},
            new int[2]{4,5}
        };
        public int[][,] jaggedmulti = new int[3][,]
        {
          new int[2,2]{ {1,2 },{3,4 } },
          new int[3,3]{{5,6,7},{8,9,10},{11,12,13}},
          new int[2,2]{{0,10},{100,1000}}
        };
        public void jaggedArrayValues()
        {
            foreach (var item in jagged)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void jaggedMultiValues()
        {
            foreach (var item in jaggedmulti)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
