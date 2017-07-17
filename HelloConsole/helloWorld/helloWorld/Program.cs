using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is your name?");

            string name = Console.ReadLine();

            for(byte i = 0; i < 100; i++)
            {
                Console.WriteLine(i + "%");
                System.Threading.Thread.Sleep(50);
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
