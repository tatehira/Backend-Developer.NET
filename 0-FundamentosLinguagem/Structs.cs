using FsCheck;
using System;

namespace MeuApp
{
    class Program
    { 
        static void Main(string[] args) 
        { 
            Product Store = new Product();

            Console.WriteLine(Store.id);
            Console.WriteLine(Store.name);
            Console.WriteLine(Store.price);
        }
    }

    struct Product
    {
        public Product (int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int id;

        public string name;

        public double price;

        public double PriceDolar (double dolar)
        {
            return price * dolar;
        }
    }
}
