using System;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    delegate double BinaryNumericOperation(double n1, double n2); // Criação do delegate.
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 20;

            BinaryNumericOperation operation = CalculationService.Sum; // Delegate é um referência para o Sum.
            //BinaryNumericOperation operation = new BinaryNumericOperation(CalculationService.Sum); // Sintaxe alternativa.
            //BinaryNumericOperation operation = new BinaryNumericOperation(CalculationService.Square); // Não pode, pois, o delegate recebe dois int, ja o Square apenas 1.


            double result = operation(a, b); // Passo os dois valores que o meu serviço pede para a classe rodar.
            //double result = operation.Invoke(a, b); // Sintaxe alternativa.
            Console.WriteLine(result); // Printar o resultado.
        }
    }
}