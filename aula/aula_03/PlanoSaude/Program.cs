namespace PlanoSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int idade;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Óla {nome}, Seja bem vindo!");

            Console.WriteLine("Digite a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade > 0 && idade <= 10)
            {
                Console.WriteLine("A mensalidade do plano é de R$ 100,00");
            }
            else if (idade >= 11 && idade <= 29)
            {
                Console.WriteLine("A mensalidade do plano é de R$ 200,00");
            }
            else if (idade >= 30 && idade <= 45)
            {
                Console.WriteLine("A mensalidade do plano é de R$ 300,00");
            }
            else if (idade >= 46 && idade <= 59)
            {
                Console.WriteLine("A mensalidade do plano é de R$ 500,00");
            }
            else if (idade >= 60 && idade <= 65)
            {
                Console.WriteLine("A mensalidade do plano é de R$ 600,00");
            }
            else
            {
                Console.WriteLine("A mensalidade do plano é de R$ 1000,00");
            }
        }
    }
}