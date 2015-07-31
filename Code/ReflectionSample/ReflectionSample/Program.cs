using System;
using System.Collections.Generic;

namespace ReflectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // We create new product.
            Product product = new Product
            {
                Brand = "Philips"
            };

            // We use our extension method GetPropertyNames to get names
            // of all properties on the class.
            IEnumerable<string> propertyNames = product.GetPropertyNames();

            // We iterate over each property name and write it to console.
            foreach (string propertyName in propertyNames)
            {
                Console.WriteLine(propertyName);
            }

            // Waiting for keypress to exit.
            Console.ReadLine();
        }
    }
}
