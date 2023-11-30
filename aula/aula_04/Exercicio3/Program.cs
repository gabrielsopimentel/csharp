namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 0, men21 = 0, mai50 = 0;


            while (idade >= 0)
            {
                Console.Write("Digite uma idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade < 21 && idade >= 0)
                    men21++;
                else if (idade > 50)
                    mai50++;
            }
            Console.WriteLine($"Total de pessoas menores de 21 anos: {men21}");
            Console.WriteLine($"Total de pessoas maiores de 50 anos: {mai50}");
        }
    }
}