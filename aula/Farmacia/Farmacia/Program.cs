using Farmacia.Controller;
using Farmacia.Model;
using System;

namespace Farmacia
{
    internal class Program
    {
        private static ConsoleKeyInfo cki;
        static void Main(string[] args)
        {
            int opcao, tipo, id;
            string nome, fragancia, generico;
            decimal preco;

            ProdutoController produtos = new ProdutoController();

            Cosmetico c1 = new Cosmetico(produtos.GerarNumero(), "sephora", 1, 12, "flor");
            produtos.CriarProduto(c1);

            Medicamento m1 = new Medicamento(produtos.GerarNumero(), "glifage", 2, 15, "sim");
            produtos.CriarProduto(m1);


            while (true)
            {
                Console.WriteLine("1 - Criar Produto");
                Console.WriteLine("2 - Listar todos os Produtos");
                Console.WriteLine("3 - Consultar Produto");
                Console.WriteLine("4 - Atualizar Produto");
                Console.WriteLine("5 - Deletar Produto");
                Console.WriteLine("6 - Sair");

                Console.Write("Entre com a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Criar produto: ");

                        do
                        {
                            Console.WriteLine("Digite o Tipo do Produto: ");
                            tipo = Convert.ToInt32(Console.ReadLine());

                        } while (tipo != 1 && tipo != 2);

                        Console.Write("Digite o Nome do Produto: ");
                        nome = Console.ReadLine();

                        Console.Write("Digite o Preço do Produto: ");
                        preco = Convert.ToDecimal(Console.ReadLine());

                        switch (tipo)
                        {
                            case 1:
                                Console.WriteLine("Digite a Fragância do Produto: ");
                                fragancia = Console.ReadLine();

                                produtos.CriarProduto(new Cosmetico(produtos.GerarNumero(), nome, tipo, preco, fragancia));
                                break;
                            case 2:
                                Console.WriteLine("Digite o Nome Genérico do Produto: ");
                                generico = Console.ReadLine();

                                produtos.CriarProduto(new Medicamento(produtos.GerarNumero(), nome, tipo, preco, generico));
                                break;

                        }

                        KeyPress();
                        break;
                    case 2:
                        Console.Write("Listar todos os produtos \n ");
                        produtos.ListarProdutos();

                        KeyPress();
                        break;
                    case 3:
                        Console.Write("Consultar produto por id: ");

                        Console.Write("Digite o id da conta: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produtos.ConsultarPorId(id);

                        KeyPress();
                        break;
                    case 4:
                        Console.Write("atualizar produto: ");

                        Console.Write("Digite o id da conta: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        var produto = produtos.BuscarColletion(id);

                        if (produto != null)
                        {
                            Console.Write("Digite o Nome do Produto: ");
                            nome = Console.ReadLine();

                            Console.Write("Digite o Preço do Produto: ");
                            preco = Convert.ToDecimal(Console.ReadLine());

                            tipo = produto.GetTipo();

                            switch (tipo)
                            {
                                case 1:
                                    Console.WriteLine("Digite a Fragância do Produto: ");
                                    fragancia = Console.ReadLine();

                                    produtos.Atualizar(new Cosmetico(id, nome, tipo, preco, fragancia));
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o Nome Genérico do Produto: ");
                                    generico = Console.ReadLine();

                                    produtos.Atualizar(new Medicamento(id, nome, tipo, preco, generico));
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"o produto {id} não foi encontrado!");
                        }

                        KeyPress();
                        break;
                    case 5:
                        Console.Write("Deletar produto: ");

                        Console.WriteLine("Digite o Id Produto: ");
                        id = Convert.ToInt32(Console.ReadLine());

                        produtos.Deletar(id);

                        KeyPress();
                        break;
                    case 6:
                        Console.Write("Saindo... ");
                        System.Environment.Exit(0);

                        KeyPress();
                        break;
                    default:
                        Console.Write("Opção inválida");

                        KeyPress();
                        break;
                }
            }
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