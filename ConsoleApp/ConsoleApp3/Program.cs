// Problema exemplo
//Fazer um programa que, a partir de uma lista de produtos, gere uma
//nova lista contendo os nomes dos produtos em caixa alta.

using System;
using ConsoleApp3.Entities;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); // Cria list inicial.
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Console.WriteLine("Initial List:");
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nSecond List, with only the names and in upper case:");
            List<string> list2 = list.Select(p => p.Name.ToUpper()).ToList(); // Cria list2 onde pega os Name da list e transforma elas para caixa alta.
            foreach(string s in list2)
            {
                Console.WriteLine(s);
            }
        }
    }
}