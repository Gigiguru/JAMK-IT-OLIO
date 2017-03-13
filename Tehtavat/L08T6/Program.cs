using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Product
    {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
    class InvoiceItem
    {

        public string Invoicers { get; set; }
        public Dictionary<Product, int> InvoiceItems { get; }
        public InvoiceItem()
        {
            InvoiceItems = new Dictionary<Product, int>();
        }
        public double Total()
        {
            double Total = 0;
            foreach (KeyValuePair<Product, int> X in InvoiceItems)
            {
                Total += X.Key.Price * X.Value;
            }

            return Total;
        }

        public override string ToString()
        {
            string Y = "";

            foreach (KeyValuePair<Product, int> X in InvoiceItems)
            {
                Y += X.Key.Name + " " + X.Key.Price + " "+ X.Value + " pieces " + X.Key.Price + "e \n";
            }
            Y += "Total " + Total() + "e";
            return Y;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceItem items = new InvoiceItem();
            items.InvoiceItems.Add(new Product("Milk", 1.75), 1);
            items.InvoiceItems.Add(new Product("Beer", 5.25), 1);
            items.InvoiceItems.Add(new Product("Butter", 2.50), 2);
            Console.WriteLine("Customer Kirsi Kernel's invoice:");
            Console.WriteLine(items.ToString());

        }
    }
}
