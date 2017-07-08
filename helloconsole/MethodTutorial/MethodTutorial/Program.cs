using System;

namespace MethodTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //just some code from my method tutorial

            int x = 60;
            int y = 9;
            int result;


           addToOutParm(x, y, out result);


            Console.WriteLine("The value of result is " + result);
            Console.WriteLine(add(x,y));
            Console.Read();
            

        }


        static int add(int x, int y)
        {
            return x + y;
        }

        static void addToOutParm(int x, int y, out int result)
        {
            result = x + y;
        }
    }
}