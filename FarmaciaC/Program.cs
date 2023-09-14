namespace FarmaciaC
{
    internal class Program
    {
        private static ConsoleKeyInfo cki;

        static void Main(string[] args)
        {
            int opcao, idade, deh, id;
            string nome;
            char genero;

            while (true)
            {
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("                Farmácia - Bem Estar                                  ");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("            1 - Criar produto                                         ");
                Console.WriteLine("            2 - Listar todos os produtos                              ");
                Console.WriteLine("            3 - Buscar produto por id                                 ");
                Console.WriteLine("            4 - Atualizar dados do produto                            ");
                Console.WriteLine("            5 - Apagar produto                                        ");
                Console.WriteLine("            6 - Sair                                                  ");
                Console.WriteLine("                                                                      ");
                Console.WriteLine("**********************************************************************");
                Console.WriteLine("Entre com a opção desejada:                                           ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Inserir produto: ");

                        KeyPress();
                        break;
                    case 2:
                        Console.WriteLine("Listar todas os produtos: ");

                        KeyPress();
                        break;
                    case 3:
                        Console.WriteLine("Buscar produto por id: ");

                        KeyPress();
                        break;
                    case 4:
                        Console.WriteLine("Atualizar dados do produto: ");

                        KeyPress();
                        break;
                    case 5:
                        Console.WriteLine("Apagar produto: ");

                        KeyPress();
                        break;
                    case 6:
                        Console.WriteLine("Saindo... ");
                        System.Environment.Exit(0);

                        KeyPress();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");

                        KeyPress();
                        break;
                }

                static void KeyPress()
                {
                    do
                    {
                        Console.WriteLine("Pressione enter para continuar...");
                        cki = Console.ReadKey();
                    } while (cki.Key != ConsoleKey.Enter);
                }
            }
        }
    }
}