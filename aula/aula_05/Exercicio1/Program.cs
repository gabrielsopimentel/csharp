namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int valor;


            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + "");
            }
            Console.WriteLine("\n");

            Console.Write("digite o número que deseja encontrar: ");
            valor = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(num, valor) != -1)
                Console.WriteLine($"O número {valor} está localizado na posição: {Array.IndexOf(num, valor)}");
            else 
                Console.WriteLine($"O número {valor} não foi encontrado!");
        }
    }
}