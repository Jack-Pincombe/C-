using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruitList = new List<string>();
            fruitList.Add("Apple");
            fruitList.Add("Orange");
            fruitList.Add("Banana");

            fruitList.Add("fig");

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }
            fruitList.Sort();
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            ReportOnFigs(fruitList);
        }

        static void ReportOnFigs(List<string> items)
        {
            string figReport =
                items.Contains("fig", StringComparer.OrdinalIgnoreCase) ?
                "Yes there are figs" :
                "No there are not figs";

            Console.WriteLine(figReport);

        }
    }
}