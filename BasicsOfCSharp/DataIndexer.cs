using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
   public class DataIndexer
    {
        private string[] strArr = new string[10]; // internal data storage

        public DataIndexer()
        {

        }

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than "+ strArr.Length + " objects");

                return strArr[index];
            }

            set
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than "+ strArr.Length + " objects");

                strArr[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (string str in strArr)
                {
                    if (str.ToLower() == name.ToLower())
                        return str;
                }

                return null;
            }
        }
    }
}
