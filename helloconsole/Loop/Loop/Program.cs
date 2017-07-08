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



            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(40);
            }



            int x = 0;
            while (x < 100)
            {
                Console.WriteLine(x);
                System.Threading.Thread.Sleep(40);
                x++;

            }
            Console.WriteLine("Hit any key to exit");
            Console.Read();
        }
    }
}