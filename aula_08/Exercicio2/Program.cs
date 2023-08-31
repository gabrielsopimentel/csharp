namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("123456", "Lucas", "40028923", "cortador@degrama.com", "31/08/2023");
            Funcionario f2 = new Funcionario("456789", "Rhyan", "40028922", "carro@carro.com", "31/08/2022");

            f1.Visualizar();
            f2.Visualizar();
            f2.SetEmail("carro@rebaixo.com");
            f2.Visualizar();
        }
    }
}