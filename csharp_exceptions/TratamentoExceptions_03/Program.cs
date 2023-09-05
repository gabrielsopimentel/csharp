namespace TratamentoExceptions_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "João", "Maria", "Pedro", "Manuela" };

            try
            {
                for (int i = 0; i < nomes.Length; i++)
                {
                    Console.WriteLine(nomes[i]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Error.WriteLine("\nExceção: " + e);
                Console.WriteLine("\nPosição Inválida");
            }

            throw new ExcecaoSimples("Exceção Simples");
        }
    }
}