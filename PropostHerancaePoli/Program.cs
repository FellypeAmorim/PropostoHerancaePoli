﻿using System;
using System.Collections.Generic;

namespace PropostHerancaePoli
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i =1; i<=n; i++)
            {
                Console.WriteLine($"Product {i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if (resp == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProducts(name, price, customsfee));
                }
                else if (resp == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacturedate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProducts(name, price, manufacturedate));
                }
                else
                {
                    list.Add(new Product(name, price));
                }              
            }
            
            Console.WriteLine();
            foreach (Product product in list)
            {
                Console.WriteLine(product.Pricetag());
            }
        }
    }
}
