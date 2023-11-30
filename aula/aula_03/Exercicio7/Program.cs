namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, res = 0;
            int opc;
            String ope = "";


            Console.Write("Digite o 1º número: ");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Soma ");
            Console.WriteLine("Subtração ");
            Console.WriteLine("Multiplicação ");
            Console.WriteLine("Divisão ");
            Console.WriteLine("Digite a operação: ");
            opc = Convert.ToInt32(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    res = num1 + num2;
                    ope = "+";
                    break;
                case 2:
                    res = num1 - num2;
                    ope = "-";
                    break;
                case 3:
                    res = num1 * num2;
                    ope = "*";
                    break;
                case 4:
                    res = num1 / num2;
                    ope = "/";
                    break;
                default:
                    Console.WriteLine("Operação invalida");
                    break;
            }
            if (opc > 0 && opc <= 4)
                Console.WriteLine($"{num1} {ope} {num2} = {res}");
        }
    }
}