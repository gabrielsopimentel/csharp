namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Insira o primeiro número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                for (int i = num1; i < num2; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                    {
                        Console.WriteLine($"{i} é multiplo de 3 e 5");
                    }
                }
            }
            else
            {
                Console.WriteLine("Intervalo inválido");
            }

        }
    }
}