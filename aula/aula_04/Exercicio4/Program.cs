namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, genero, stack, devbackend = 0, mulherFront = 0, homemMobileM40 = 0, nBinarioFSm30 = 0, total = 0, mediaIdade = 0;
            string continua = "S";

            while (continua.Equals("S"))
            {
                Console.Write("Digite sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1 - Mulher cis ");
                Console.WriteLine("2 - Homem cis ");
                Console.WriteLine("3 - Não binário ");
                Console.WriteLine("4 - Mulher trans ");
                Console.WriteLine("5 - Homem trans ");
                Console.WriteLine("6 - Outros ");

                Console.Write("Identidade de gênero: ");
                genero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1 - Backend");
                Console.WriteLine("2 - Frontend ");
                Console.WriteLine("3 - Mobile ");
                Console.WriteLine("4 - Fullstack ");

                Console.Write("Pessoa desenvolvedora: ");
                stack = Convert.ToInt32(Console.ReadLine());

                if (stack == 1)
                {
                    devbackend++;
                }

                if ((genero == 1 || genero == 4) && stack == 2)
                {
                    mulherFront++;
                }

                if ((genero == 2 || genero == 5) && stack == 3 && idade > 40)
                {
                    homemMobileM40++;
                }

                if (genero == 3 && stack == 4 && idade < 30)
                {
                    nBinarioFSm30++;
                }

                mediaIdade += idade;
                total++;

                Console.Write("Deseja continua [S/N]?: ");
                continua = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Total de pessoas desenvolvedoras Backend: {devbackend}");
            Console.WriteLine($"Total de mulheres cis e trans desenvolvedoras frontend: {mulherFront}");
            Console.WriteLine($"Total de homens cis e trans desenvolvedores mobile maiores de 40 anos: {homemMobileM40}");
            Console.WriteLine($"Total de pessoas não binárias desenvolvedoras fullstack menores de 30 anos: {nBinarioFSm30}");
            Console.WriteLine($"Número total de pessoas que responderam à pesquisa: {total}");
            Console.WriteLine($"Média de idade das pessoas que responderam à pesquisa: {mediaIdade / total}");

        }
    }
}