using System;
using System.Linq;


//This app is to use the skills I have learned and make a console calculator
namespace CalculatorApp



{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            Console.WriteLine("Please enter the two numbers you wish to use followed by the operator");
            long num1 = UserIn(1);
            long num2 = UserIn(2);
            string oper = UserIn();

            switch (oper)
            {
                case "A":
                    Console.WriteLine("ans: " + (num1 + num2));
                    again();
                    break;

                case "S":
                    Console.WriteLine("ans: " + (num1 - num2));
                    again();
                    break;

                case "D":
                    Console.WriteLine("ans: " + (num1 / num2));
                    again();
                    break;


                case "M":
                    Console.WriteLine("ans: " + (num1 * num2));
                    again();
                    break;


                default:
                    break;
            }
        }

        static void again()
        {
            Console.WriteLine("Would you like to go again?");
            string ans = Console.ReadLine();

            if (ans.ToUpper() == "Y")
            {
                 Calculator();
            }
            else
            {
                Console.WriteLine( "Thank you for using the calculator");
                System.Threading.Thread.Sleep(2000);
            }

        }

        static int UserIn(int num)
        {
            
            Console.WriteLine(num + ":");
            string x = Console.ReadLine();

            int number;

            if (Int32.TryParse(x,out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Please enter a integer value");
                return UserIn(num);
            }
        }
        static string UserIn()
        {

            Console.WriteLine("Please enter either (A)dd, (S)ubtract, (M)uliply or (D)ivide");
            var op = Console.ReadLine();
            op = op.ToUpper();

            string[] possible = { "A", "S", "M", "D" };

            if (possible.Contains(op) == false)
            {
                return UserIn();
            }
            else
            {
                return op;
            }



        }
    }
}