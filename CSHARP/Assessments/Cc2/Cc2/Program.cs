using System;
using System.Collections.Generic;

namespace Cc2
{

    class Product
    {
        public int ProductId;
        public string ProductName;
        public decimal Price;
    }

    class Program
    {
        public static void Main()
        {
           
            List<Product> products = new List<Product>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter details for product {i + 1}:");
                Product product = new Product();

                Console.Write("Product Name: ");
                product.ProductName = Console.ReadLine();

                Console.Write("Price: ");
                product.Price = Convert.ToDecimal(Console.ReadLine());

                product.ProductId = i + 1;
                products.Add(product);
            }
            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = i + 1; j < products.Count; j++)
                {
                    if (products[i].Price > products[j].Price)
                    {
                        Product temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted Products by their Price:");
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.ProductName}, Price: {product.Price:C}");
            }

           

            Console.ReadLine();
        }
    }
}