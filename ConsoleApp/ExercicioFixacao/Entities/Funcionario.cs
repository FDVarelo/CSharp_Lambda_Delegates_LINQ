using System;

namespace ExercicioFixacao.Entities
{
    class Funcionario
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Funcionario(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
