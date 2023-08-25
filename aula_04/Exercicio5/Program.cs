namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, somaPares = 0;

            do
            {
                Console.Write("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    somaPares += num;
                }

            } while (num != 0);
            Console.WriteLine($"A soma dos números positivos é: {somaPares}");
        }
    }
}