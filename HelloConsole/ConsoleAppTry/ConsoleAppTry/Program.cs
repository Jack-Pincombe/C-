using System;

namespace ConsoleAppTry
{
    class Program
    {
        static void Main(string[] args)
        {
            try
                {
                    string[] fruit = { "Apples", "Oranges", null, "Pineapples" };
                for (int i = 0; i <= fruit.Length; i++)
                {
                    //if (fruit[i] == null)
                    //{
                    //    throw (new ArgumentNullException());
                    //}

                    Console.WriteLine("The fruit is " + fruit[i]);
                }
                Console.ReadKey();
                }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index Problem");
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Null Problem");
                Console.WriteLine(ex.Message);
            }

         
        }
    }
}