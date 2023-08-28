namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            float soma = 0, media = 0;

            Console.WriteLine("Elementos nos indices ímpares: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(num[i] + " ");
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Elementos pares: ");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.Write(num[i] + " ");
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < num.Length; i++)
            {
                soma += num[i];
            }

            media = soma / num.Length;
            Console.WriteLine($"Soma: {soma}\n");
            Console.WriteLine($"Média: {media:f2}");
        }
    }
}