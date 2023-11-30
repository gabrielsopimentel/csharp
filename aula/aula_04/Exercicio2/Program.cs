namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digito, par = 0, impar = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                digito = Convert.ToInt32(Console.ReadLine());

                if (digito % 2 == 0)
                {
                    par += 1;
                }
                else
                {
                    impar += 1;
                }
            }
                Console.WriteLine($"Total de números pares: {par}");
                Console.WriteLine($"Total de números impares: {impar}");
        }
    }
}