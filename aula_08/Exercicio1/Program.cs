namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("12345678910","Vitor","40028923","cortador@degrama.com","31/08/2023");
            Cliente c2 = new Cliente("01987654321","Allan","40028922","carro@carro.com","31/08/2022");

            c1.Visualizar();
            c2.Visualizar();
            c2.SetEmail("carro@rebaixo.com");
            c2.Visualizar();

        }
    }
}