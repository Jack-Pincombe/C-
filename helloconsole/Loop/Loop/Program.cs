using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = { "Apples", "Oranges", "Grapes" }; 

            foreach(string i in fruit)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(10);
            }

            Console.Read();
        }
    }
}