namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, flag;
            int idade;
            bool pdoacao = false;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());


            Console.Write("É sua primeira doação [S]/[N]?: ");
            flag = Console.ReadLine().ToUpper();

            if (flag.Equals("S"))
                pdoacao = true;
            else if (flag.Equals("N"))
                pdoacao = false;
            else
                Console.WriteLine("Invalido");

            if (idade >= 18 && idade <= 60)
                Console.WriteLine($"{nome} está apto para doar sangue");
            else if (idade > 60 && idade <= 69 && pdoacao == false)
                Console.WriteLine($"{nome} está apto para doar sangue");
            else
                Console.WriteLine($"{nome} não está apto para doar sangue");
        }
    }
}