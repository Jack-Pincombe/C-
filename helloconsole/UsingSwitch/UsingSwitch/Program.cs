using System;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Xyz();

    

            void Xyz()
            {

                Console.WriteLine("Enter an operation: + - * /");
                string operation = Console.ReadLine();

                switch (operation)
                {

                    case "+":
                        Console.WriteLine("You chose to add");
                        break;

                    case "-":
                        Console.WriteLine("You chose to substract");
                        break;

                    case "/":
                        Console.WriteLine("You chose to divide");
                        break;

                    case "*":
                        Console.WriteLine("You chose to multiply");
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Would you like to go again?");
                string inp = Console.ReadLine();
                if (inp == "y")
                {
                    Xyz();
                }
                else
                {
                    Console.Beep();
                }

                    

            }


            
        }
    }
}