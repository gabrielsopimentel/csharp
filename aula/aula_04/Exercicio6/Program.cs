namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 0;
            float media = 0;

            do
            {
                Console.Write("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 3 == 0 && num > 0)
                {
                    media += num;
                    i++;
                }
            } while (num != 0);
            Console.WriteLine($"A média de todos os números múltiplos de 3 é: {media / i}");
        }
    }
}