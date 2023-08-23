using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono, novoSalario;

            Console.WriteLine("Digita salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digita abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            novoSalario = salario + abono;

            Console.WriteLine("Novo salário: " + novoSalario);
        }
    }
}