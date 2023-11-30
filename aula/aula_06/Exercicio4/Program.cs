namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            HashSet<int> numeros = new HashSet<int>() { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };

            foreach (var numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.Write("\n");

            Console.Write("Digite o número que deseja encontrar: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (numeros.Contains(num))
            {
                Console.WriteLine($"O número {num} foi encontrado!");
            }
            else
            {
                Console.WriteLine($"O número {num} não foi encontrado!");
            }

        }
    }
}