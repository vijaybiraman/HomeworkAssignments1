using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialOfNum
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int res = GetFactorial(num);
            Console.WriteLine("factorial of given number is " + res);
            Console.ReadLine();
        }
        static int GetFactorial(int num)
        {
            int fact = 1;
            for(int i = 1; i<=num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
