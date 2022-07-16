using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 11, 19, 12, 18, 13, 17, 14, 16, 15, 20 };
            Console.WriteLine("the input array is :");
            for(int i =0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The sorted array is :");
            for(int i = 0; i< arr.Length; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                Console.Write( arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
