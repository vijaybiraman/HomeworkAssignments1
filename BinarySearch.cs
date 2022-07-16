using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleAndBinary
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr= { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int start = 0;
            int end = arr.Length;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (num == arr[mid])
                {
                    Console.WriteLine("Found at index " + mid);
                    break;
                }
                else if(num > arr[mid])
                {
                    start = mid + 1;
                }
                else if(num < arr[mid])
                {
                    end = mid - 1;
                }
            }
            if(start >= end)
            {
                Console.WriteLine("not found");
            }
            Console.ReadLine();
        }
    }
}
