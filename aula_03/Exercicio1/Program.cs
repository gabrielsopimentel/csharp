namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, soma;

            Console.Write("Insira o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o terceiro número: ");
            c = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            if (soma < c)
                Console.Write("A soma de A + B é menor do que C ");
            else if (soma > c)
                Console.Write("A soma de A + B é maior do que C ");
            else
                Console.Write("A soma de A + B é igual do que C ");

        }
    }
}