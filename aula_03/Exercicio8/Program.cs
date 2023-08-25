namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            float valor, saldo = 1000;

            Console.WriteLine("Código da operação 1: Saldo");
            Console.WriteLine("Código da operação 2: Saque");
            Console.WriteLine("Código da operação 3: Depósito");

            do
            {
            Console.Write("Digite a operação 1,2 ou 3: ");
            op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Sair");
                        break;
                    case 1:
                        Console.Write("Operação - Saldo ");
                        Console.WriteLine($"Saldo: {saldo:f2}");
                        break;
                    case 2:
                        Console.Write("Digite o valor: ");
                        valor = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine("Operação - Saque ");
                        if (valor < saldo)
                        {
                            saldo -= valor;
                            Console.WriteLine($"Novo saldo: {saldo:f2}");
                        }
                        else
                            Console.WriteLine("Saldo Insuficiente");
                        break;
                    case 3:
                        Console.Write("Digite o valor: ");
                        valor = Convert.ToSingle(Console.ReadLine());
                        saldo =+ valor;
                        Console.WriteLine("Operação - Deposito ");
                        Console.WriteLine($"Novo saldo: {saldo:f2}");
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (op != 0);


        }
    }
}