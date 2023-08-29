using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digito;
            List<int> numeros = new List<int>() { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };

            foreach (int numero in numeros) { Console.Write(numero + " "); }

            Console.Write("\n");

            Console.Write("Digite o número que você deseja encontrar: ");
            digito = Convert.ToInt32(Console.ReadLine());

            if (numeros.Contains(digito))
                Console.WriteLine($"O número esta localizado na posição: {numeros.IndexOf(digito)}");
            else
                Console.WriteLine($"O número {digito} não foi encontrado!");
        }
    }
}