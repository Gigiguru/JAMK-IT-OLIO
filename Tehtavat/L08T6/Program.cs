using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
   class Invoiceitem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantify { get; set; }
        public Invoiceitem() { }
        public Invoiceitem(string name, double price, int quantify)
        {
            Name = name;
            Price = price;
            Quantify = quantify;

        }
        public double Total()
        { return Price * Quantify; }
        public override string ToString()
        {
            return Name + " " + Price + "e " + Quantify + " pieces " + Total() + " total";
        }
    }
    class Invoice
    {
        public string Customer { get; set; }
        private List<Invoiceitem> X { get; }
        public Invoice(string customer)
        {
            Customer = customer;
            X = new List<Invoiceitem>();
        }
        public void Add(Invoiceitem item)
        {
            X.Add(item);
        }
        public string Total()
        {
            double total = 0;
            foreach (Invoiceitem item in X)
            {
                total += item.Total();
            }
            string I = "Total's " + total;
            return I;
        }
        public void PrintInvoice()
        {
            string y = "Customer " + Customer + " invoice: \n";
            foreach (Invoiceitem item in X)
            {
                y += item.ToString() + "\n";
            }
            y += Total() + "e";
            Console.WriteLine(y);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("Kirsi");
            invoice.Add(new Invoiceitem("Milk", 1.75, 1));
            invoice.Add(new Invoiceitem("Beer", 1.75, 1));
            invoice.Add(new Invoiceitem("Butter", 1.75, 2));
            invoice.PrintInvoice();

        }
    }
}
