namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod, qtd;
            float total = 0;
            string? prod;

            Console.WriteLine("Código 1: Cachorro Quente | R$ 10,00");
            Console.WriteLine("Código 2: X — Salada | R$ 15,00");
            Console.WriteLine("Código 3: X — Bacon | R$ 18,00");
            Console.WriteLine("Código 4: Bauru | R$ 12,00");
            Console.WriteLine("Código 5: Refrigerante | R$ 8,00");
            Console.WriteLine("Código 6: Suco de laranja | R$ 13,00");

            Console.Write("Digite o código do produto: ");
            cod = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade do produto: ");
            qtd = Convert.ToInt32(Console.ReadLine());

            switch (cod)
            {
                case 1:
                    {
                        total = qtd * 10;
                        Console.WriteLine("Produto: Cachorro Quente");
                        break;
                    }
                case 2:
                    {
                        total = qtd * 15;
                        Console.WriteLine("Produto: X — Salada");
                        break;
                    }
                case 3:
                    {
                        total = qtd * 18;
                        Console.WriteLine("Produto: X — Bacon");
                        break;
                    }
                case 4:
                    {
                        total = qtd * 12;
                        Console.WriteLine("Produto: Bauru");
                        break;
                    }
                case 5:
                    {
                        total = qtd * 8;
                        Console.WriteLine("Produto: Refrigerante");
                        break;
                    }
                case 6:
                    {
                        total = qtd * 13;
                        Console.WriteLine("Produto: Suco de laranja");
                        break;
                    }
                default: Console.WriteLine("Invalido"); break;
            }
            Console.WriteLine($"Valor total: R${total:f2}");

        }
    }
}