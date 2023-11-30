namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste = 0;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");

            Console.Write("Digite o cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine($"Nome do colaborador: {nome}");

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 10) / 100;
                    Console.WriteLine("Cargo: Gerente");
                    break;
                case 2:
                    reajuste = (salario * 7) / 100;
                    Console.WriteLine("Cargo: Vendedor");
                    break;
                case 3:
                    reajuste = (salario * 9) / 100;
                    Console.WriteLine("Cargo: Supervisor");
                    break;
                case 4:
                    reajuste = (salario * 6) / 100;
                    Console.WriteLine("Cargo: Motorista");
                    break;
                case 5:
                    reajuste = (salario * 5) / 100;
                    Console.WriteLine("Cargo: Estoquista");
                    break;
                case 6:
                    reajuste = (salario * 8) / 100;
                    Console.WriteLine("Cargo: Técnico de TI");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
            Console.WriteLine($"Salário: R$ {salario + reajuste:f2}");
        }
    }
}