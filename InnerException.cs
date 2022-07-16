using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace DeMo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter the first number");
                    int firstnumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    int secondtnumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ans is " + firstnumber / secondtnumber);
                }
                catch (Exception ex)
                {
                    string filepath = @"D:\MyFile\path1.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter str = new StreamWriter(filepath);
                        str.Write(ex.GetType().Name);
                        str.WriteLine();
                        str.Write(ex.Message);
                        str.Close();
                        Console.WriteLine("input is wrong");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + "is not found", ex);
                    }
                }
            }
            catch(Exception ex1)
            {
                Console.WriteLine("current Exception "+ex1.GetType().Name);
                Console.WriteLine("inner Exception "+ex1.InnerException.GetType().Name);
            }

            Console.ReadLine();
        }
    }
}
