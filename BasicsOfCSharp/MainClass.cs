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
            Console.WriteLine(AnonymousType.AnonymousMethod());
            IInterfaceTopics i1 = new ImplementingInterface();
            i1.DoSome();
            IInterfaceTopics i2 = new AnotherImplemetation();
            i2.DoSome();
            IInterfaceTopics i3 = new ExplicitlyImplementation();
            i3.DoSome();
            //tructure object without using new keyword
            StructExample s1;
            s1.EmpId = 10;
            Console.WriteLine(s1.EmpId);
            //tructure object with using new keyword
            StructExample s2 = new StructExample(1,"shashi","guru");
            Console.WriteLine(s2.EmpId);
            Console.WriteLine(s2.FirstName);
            Console.WriteLine(s2.LastName);
            Console.WriteLine((int)EnumExample.Monday);
            Console.WriteLine(Enum.GetName(typeof(EnumExample), 4));
            foreach (string str in Enum.GetNames(typeof(EnumExample)))
                Console.WriteLine(str);
            //StringBuilder is a dynamic object that allows you to expand the number of characters in the string.
            //It doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string.
            StringBuilder sb = new StringBuilder("Hello Shashiguru!!");
            Console.WriteLine(sb);
            sb.Insert(16," Keluth");
            Console.WriteLine(sb);
            sb.Append("??");
            Console.WriteLine(sb);
            PartialClass p = new PartialClass();
            p.Method1();
            p.Method2();
            StaticClass.StaticMethod();
            Console.WriteLine(StaticClass.StaticVariable);
            StaticConstructorClass s = new StaticConstructorClass();
            StaticConstructorClass s5 = new StaticConstructorClass();
            StaticConstructorClass s6 = new StaticConstructorClass();
            WithStatic.somemethod();
            JaggedArray ja = new JaggedArray();
            ja.jaggedArrayValues();
            ja.jaggedMultiValues();
            DataIndexer strStore = new DataIndexer();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            Console.WriteLine(strStore["one"]);
            Console.WriteLine(strStore["two"]);
            Console.WriteLine(strStore["Three"]);
            Console.WriteLine(strStore["FOUR"]);
            TupleEx t = new TupleEx();
            t.TupleAccessing();
            t.TupleAsParameter(Tuple.Create(1,"shashi","guru"));
            var t1=t.TupleAsReturn();
            Console.WriteLine(t1.Item1);
            Console.WriteLine(t1.Item2);
            Console.WriteLine(t1.Item3);
            ArrayListEx arrayList = new ArrayListEx();
            arrayList.ArrayListMethod();
            SortedListEx sortList = new SortedListEx();
            sortList.SortedMetohd();
            HashEx hash = new HashEx();
            hash.HashMethod();
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



