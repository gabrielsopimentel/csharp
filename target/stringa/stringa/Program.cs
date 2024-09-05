namespace stringa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            int contagem = 0;
            foreach (char c in input.ToLower())
            {
                if (c == 'a')
                {
                    contagem++;
                }
            }

            if (contagem > 0)
            {
                Console.WriteLine($"A letra 'a' ocorre {contagem} vezes na string.");
            }
            else
            {
                Console.WriteLine("A letra 'a' não foi encontrada na string.");
            }
        }
    }
}
