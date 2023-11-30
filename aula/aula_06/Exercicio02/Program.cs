namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            string? titulo;
            Stack<string> livros = new Stack<string>();

            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("********************************************************");
                Console.WriteLine("                                                        ");
                Console.WriteLine("         1 - Adicionar livro na pilha                   ");
                Console.WriteLine("         2 - Listar todos os livros da pilha            ");
                Console.WriteLine("         3 - Retirar livro da pilha                     ");
                Console.WriteLine("         0 - Sair                                       ");
                Console.WriteLine("                                                        ");
                Console.WriteLine("********************************************************");
                Console.WriteLine("Entre com a opção desejada:                             ");
                Console.WriteLine("                                                        ");
                Console.ResetColor();

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    Console.WriteLine("\nPrograma foi finalizado!");
                    System.Environment.Exit(0);
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o título do livro: ");
                        titulo = Console.ReadLine();
                        livros.Push(titulo);
                        Console.WriteLine("Livro foi adicionado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Lista de livros");
                        foreach (var livro in livros)
                            Console.WriteLine(livro);
                        break;
                    case 3:
                        if (livros.Count == 0)
                        {
                            Console.WriteLine("A pilha está vazia");
                        }
                        else
                        {
                            livros.Pop();
                            Console.WriteLine("Livro foi retirado com sucesso!");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}