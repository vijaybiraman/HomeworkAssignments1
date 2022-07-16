using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOfAmsAndNeon
{
    internal class ArmstrongNumber
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the number");
             int num = Convert.ToInt32(Console.ReadLine());
             int add = 0;
             int temp = num;
             while(temp > 0)
             {
                int rem = temp % 10;
                 add = add + rem*rem*rem;
                temp = temp/ 10;
             }
             if(add==num)
             {
                  Console.WriteLine(num +" is a armstrong number");
             }
             else
             {
                 Console.WriteLine(num +" is not armstrong number");
             }
             Console.ReadLine();
        }
    }
}
