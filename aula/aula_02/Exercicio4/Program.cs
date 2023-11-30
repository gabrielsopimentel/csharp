namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, calculo;

            Console.WriteLine("Digite o número 1: ");
            n1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            n2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número 3: ");
            n3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o número 4: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            calculo = (n1 * n2) - (n3 * n4);

            Console.WriteLine("O produto é: " + calculo);
        }
    }
}