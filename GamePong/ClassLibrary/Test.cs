using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Test
    {
        static void Main(string[] args)
        {
            GenericList<string> list = new GenericList<string>();
            list.Add("Dobar");
            list.Add("Dan");
            list.Add("Dragi");
            list.Add("Svijete");

            Console.WriteLine("Contains Dan: " + list.Contains("Dan"));
            list.Remove("Dragi");
            Console.WriteLine("Contains Svijete: " + list.Contains("Svijete"));
            Console.WriteLine("Broj elemenata: " + list.Count);
            Console.WriteLine("Index of Dragi: " + list.IndexOf("Svijete"));
            Console.WriteLine("Prvi element je: " + list.GetElement(0));
            list.Clear();
            Console.WriteLine("Broj elemenata je: " + list.Count);
            Console.ReadLine();
        }
    }
}

