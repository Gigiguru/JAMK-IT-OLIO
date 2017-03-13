using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;

        }

        public override string ToString()
        {
            return "- product : " + Name + " " + Price + " e ";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Product> ShoppingCart = new List<Product>();
            ShoppingCart.Add(new Product("Milk", 1.4));
            ShoppingCart.Add(new Product("Beer", 2.2));
            ShoppingCart.Add(new Product("Butter", 3.2));
            ShoppingCart.Add(new Product("Cheese", 4.2));
            Console.WriteLine("All products in collection:");
            foreach (Product x in ShoppingCart)
            {
                Console.WriteLine(x.ToString());
            }

        }
    }
}
