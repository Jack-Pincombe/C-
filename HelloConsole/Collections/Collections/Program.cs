using System;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = { "Apples", "Oranges", "Grapes" };

            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            string[] names = new string[3];
            names[0] = "Joe";
            names[1] = "Jack";
            names[2] = "Bob";

            int[] weights = { 12, 342, 54, 23, 4 };

            int sum = weights.Sum();
            Console.WriteLine("The sum of weights is " + sum);

            double avg = weights.Average();
            Console.WriteLine("The average of weights is " + avg);

            UseArray(names);
        }

        static void UseArray(string[] values)
        {
            Console.WriteLine("The values are ");

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}