namespace fibo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número:");
            int num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            Console.Write("Sequência de Fibonacci: {0} {1}", a, b);

            int c = a + b;

            while (c <= num)
            {
                Console.Write(" {0}", c);
                a = b;
                b = c;
                c = a + b;
            }

            Console.WriteLine();

            if (num == a || num == b)
            {
                Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
            }
        }
    }
}
