using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewIntegerList
{
    class Test
    {
        static void TestJedan(IIntegerList list)
        {
            list.Add(11);
            list.Add(22);
            list.Add(33);

            Console.WriteLine(list.Count);

            list.RemoveAt(0);
            list.Add(44);
            list.Add(55);
            list.Remove(33);
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((i + 1) + ". element je: " + list.GetElement(i));
            }
            Console.WriteLine("Index of 55: " + list.IndexOf(55) + "\n");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Contains(99));
            Console.WriteLine(list.Count);
           
            Console.WriteLine(list.RemoveAt(99));
            Console.WriteLine(list.IndexOf(99));
            Console.WriteLine(list.Count);

        }
        static void Main(string[] args)
        {
            IntegerList list = new IntegerList(20);

            TestJedan(list);
            Console.ReadLine();
        }
    }
}

