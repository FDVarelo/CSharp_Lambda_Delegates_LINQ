using System;
using System.Collections.Generic;
using ConsoleApp2.Entities;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problema exemplo
            // Fazer um programa que, a partir de uma lista de produtos, remova da
            // lista somente aqueles cujo preço mínimo seja 100.
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100.00); // Lambda.
            list.RemoveAll(ProductTest); // Outra forma.
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n\nSegundo Exemplo:\n");
            //Problema exemplo
            //Fazer um programa que, a partir de uma lista de produtos, aumente o
            //preço dos produtos em 10 %.
            List<Product> listIncrease = new List<Product>();
            listIncrease.Add(new Product("Tv", 900.00));
            listIncrease.Add(new Product("Mouse", 50.00));
            listIncrease.Add(new Product("Tablet", 350.50));
            listIncrease.Add(new Product("HD Case", 80.90));

            Console.WriteLine("Lista inicial:");
            foreach (Product product in listIncrease)
            {
                Console.WriteLine(product);
            }

            Action<Product> act = UpdatePrice;
            // Outra forma:
            Action<Product> actIncrease = p => { p.Price += p.Price * 0.1; }; // Também pode ser colocado diretamente no listIncreave.ForEach.

            Console.WriteLine("\nLista final:");
            listIncrease.ForEach(act); // act pode ser também substituido por UpdatePrice.
            foreach(Product product in listIncrease)
            {
                Console.WriteLine(product);
            }
        }
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}