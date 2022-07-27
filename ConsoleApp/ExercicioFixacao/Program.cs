using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using ExercicioFixacao.Entities;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Insira o caminho do arquivo: ");
            //string path = Console.ReadLine();

            string path = @"C:\temp\CSharp_Lambda_Delegates_LINQ\ConsoleApp\ExercicioFixacao\files\file.csv";

            List<Funcionario> list = new List<Funcionario>();

            using (StreamReader sr = File.OpenText(path)) // Abrindo o arquivo.
            {
                while (!sr.EndOfStream) // Rodando todo o arquivo.
                {
                    string[] fields = sr.ReadLine().Split(','); // Separando em tabela, a cada virgula encontrada.
                    string name = fields[0]; // Name é a primeira coluna.
                    string email = fields[1]; // Email do funcionario é a segunda coluna
                    double price = double.Parse(fields[2], CultureInfo.InvariantCulture); // Salary é a terceira coluna.
                    list.Add(new Funcionario(name, email, price)); // Adiciona o novo produto a lista com o seu respectivo nome, email e salario.
                }
            }

            Console.WriteLine("Quantidade do Salario: ");
            double userSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Salario que o usuário ira passar.

            Console.WriteLine("Email dos funcionarios que tem o salario maior que " + userSalary.ToString("F2", CultureInfo.InvariantCulture) + ": ");

            var people = list.Where(p => p.Salary > userSalary).OrderBy(p => p.Email).Select(p => p.Email); // Ordenar em ordem alfabetica as pessoas cujo o salario é maior que o selecionado.
            foreach (string name in people) // Roda todos os nomes.
            {
                Console.WriteLine(name); // Printa os nomes.
            }

            var sum = list.Where(p => p.Name[0] == 'M').Sum(p => p.Salary); // Pega todos os funcionario que o nome inicia com 'M', e soma o salario deles.
            Console.WriteLine("Soma do salario dos funcionacio que o nome começa com 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}