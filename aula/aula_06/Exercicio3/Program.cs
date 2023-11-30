namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numeros = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}