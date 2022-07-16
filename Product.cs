using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib
{
    public class Product
    {
        private string productname;
       private decimal price;
        private int quantity;

        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product()
        {

        }

        public Product(string productname, decimal price,int quantity)
        {
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal ProductCost()
        {
            return price * quantity;
        }

        public override string ToString()
        {
            return String.Format($"ProductName: {productname}, Price: {price}, Quantity: {quantity}");
        }
    }
}
