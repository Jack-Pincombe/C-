using System;

namespace ConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of numbers to count");
            string x = Console.ReadLine();
            int y;

            if(Int32.TryParse(x, out y))
            {
                for (int i = 0; i < y; i++)
                {
                    Console.WriteLine(i);
                    System.Threading.Thread.Sleep(50);
                }
            }
            else
            {
                Console.WriteLine("Please ensure you enter a valid number into the console ");
                Console.Read();
            }
                

            
        }
    }
}