using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCartLib;
namespace AmazonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Himalaya", 100.5M, 10);
            Console.WriteLine(product.ToString());
            Console.WriteLine("product cost is :" + product.ProductCost());
            Console.ReadLine();

        }
    }
}
