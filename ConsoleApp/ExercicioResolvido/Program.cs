using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using ExercicioResolvido.Entities;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Insira o caminho do arquivo: ");
            //string path = Console.ReadLine();

            string path = @"C:\temp\CSharp_Lambda_Delegates_LINQ\ConsoleApp\ExercicioResolvido\files\file.csv";

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path)) // Abrindo o arquivo.
            {
                while (!sr.EndOfStream) // Rodando todo o arquivo.
                {
                    string[] fields = sr.ReadLine().Split(','); // Separando em tabela, a cada virgula encontrada.
                    string name = fields[0]; // Name é a primeira coluna.
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // Price é a segunda coluna.
                    list.Add(new Product(name, price)); // Adiciona o novo produto a lista com o seu respectivo nome e preço.
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Pega o preço medio levando em conta que tem que ter pelomenos o valor minimo de 0.0;
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name); // Apenas os produtos que tem o preço menor que a média, e ordenando em ordem alfabetica ao contratia.
            foreach (string name in names) // Roda todos os nomes.
            {
                Console.WriteLine(name); // Printa os nomes.
            }
        }
    }
}