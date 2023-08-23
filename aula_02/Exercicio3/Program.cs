namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float bruto, noturno, extras, descontos, liquido = 0;
            
            Console.WriteLine("Salário bruto: ");
            bruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Adicional Noturno: ");
            noturno = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Horas Extras: ");
            extras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Descontos: ");
            descontos = Convert.ToSingle(Console.ReadLine());

            liquido = bruto + noturno + (extras * 5) - descontos;

            Console.WriteLine("Salário líquido: " + liquido);

        }
    }
}