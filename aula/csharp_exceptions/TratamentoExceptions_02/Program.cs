namespace TratamentoExceptions_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            try 
            {
                
            Console.WriteLine("\nDigite uma idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            ValidarIdade(idade);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Digite uma idade maior ou igual a 18 anos");
            }
        }

        public static void ValidarIdade(int idade)
        {

            if (idade < 18)
                throw new ArithmeticException("A Pessoa não pode dirigir!!");
            else
                Console.WriteLine("A Pessoa pode dirigir!!");

        }

    }
}