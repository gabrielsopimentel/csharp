namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digita;

            List<string> cores = new List<string>();

            do
            {
                Console.Write("Digite uma cor: ");
                digita = Console.ReadLine();
                cores.Add(digita);

            } while (cores.Count < 5);

            Console.WriteLine("\n");

            Console.WriteLine("Lista de todas as cores: ");
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }

            cores.Sort();

            Console.WriteLine("\nOrdenar as cores: ");
            foreach (string cor in cores)
            {
                Console.WriteLine(cor);
            }
        }
    }
}