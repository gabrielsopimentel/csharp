namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            int opcao;
            string? nome;

            while (true)
            {
                Console.WriteLine("********************************************************");
                Console.WriteLine("                                                        ");
                Console.WriteLine("         1 - Adicionar Cliente na fila                  ");
                Console.WriteLine("         2 - Listar todos os clientes                   ");
                Console.WriteLine("         3 - Retirar cliente da fila                    ");
                Console.WriteLine("         0 - Sair                                       ");
                Console.WriteLine("                                                        ");
                Console.WriteLine("********************************************************");
                Console.WriteLine("Entre com a opção desejada:                             ");
                Console.WriteLine("                                                        ");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("\nPrograma foi finalizado!");
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        clientes.Enqueue(nome);
                        Console.WriteLine("Cliente adicionado!");
                        break;
                    case 2:
                        Console.WriteLine("Fila: ");
                        foreach (var cliente in clientes)
                        {
                            Console.WriteLine(cliente);
                        }
                        break;
                    case 3:
                        clientes.Dequeue();
                        foreach (var cliente in clientes)
                        {
                            Console.WriteLine(cliente);
                        }
                        Console.WriteLine("Cliente foi chamado!");
                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }
        }
    }
}