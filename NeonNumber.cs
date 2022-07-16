using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonNumber
{
    internal class NeonNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The neon numbers is :");
            int num = 1;
            while (num < 1000)
            {
                int sqr = num * num;
                int add = 0;
                while (sqr > 0)
                {
                    int rem = sqr % 10;
                    add = add + rem;
                    sqr = sqr / 10;
                }
                if (add == num)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.ReadLine();
        }
    }
}
    
