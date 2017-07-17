using System;

namespace ConsoleAppTry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
                {
                    string[] fruit = { "Apples", "Oranges", "Pineapples" };
                for (int i = 0; i <= fruit.Length; i++)
                {
                    Console.WriteLine("The fruit is " + fruit[i]);
                }
                Console.ReadKey();
                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

         
        }
    }
}