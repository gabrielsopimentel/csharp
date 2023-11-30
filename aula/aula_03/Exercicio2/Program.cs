namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Entre com um número positivo ou negativo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0 && num > 0)
                Console.WriteLine($"O número {num} é par e positivo ");
            else if (num % 2 == 0 && num < 0)
                Console.WriteLine($"O número {num} é par e negativo ");
            else if (num % 2 != 0 && num > 0)
                Console.WriteLine($"O número {num} é impar e positivo ");
            else if (num % 2 != 0 && num < 0)
                Console.WriteLine($"O número {num} é impar e negativo ");
            else Console.WriteLine($"O número {num}");

        }
    }
}