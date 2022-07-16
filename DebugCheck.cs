using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggersChecking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num <= 4)
            {
                Console.WriteLine("Enter a number1");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a number2");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    int add = Calculator.Addition(num1, num2);
                    Console.WriteLine("Addition is " + add);
                    Console.WriteLine("enter a number");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 2)
                {
                    int sub = Calculator.Subtraction(num1, num2);
                    Console.WriteLine("Subtraction is " + sub);
                    Console.WriteLine("enter a number");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 3)
                {
                    int mul = Calculator.Multiplication(num1, num2);
                    Console.WriteLine("Multiplication is " + mul);
                    Console.WriteLine("enter a number");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 4)
                {
                    int div = Calculator.Division(num1, num2);
                    Console.WriteLine("Division is " + div);
                    Console.WriteLine("enter a number");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
        class Calculator
        {
          public static int Addition(int num1,int num2)
            {
                return num1 + num2;
            }

            public static int Subtraction(int num1, int num2)
            {
                return num1 - num2;
            }

            public static int Multiplication(int num1, int num2)
            {
                return num1 * num2;
            }

            public static int Division(int num1, int num2)
            {
                return num1 / num2;
            }
        }
    }
}
