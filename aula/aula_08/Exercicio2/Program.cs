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

            Vendedor v1 = new Vendedor("111111", "josi", "12345678" , "gen@gen", "31/08/2020", 709.0f);
            Vendedor v2 = new Vendedor("222222", "mara", "87654321" , "pog@pog", "31/08/2021", 705.0f);

            Gerente g1 = new Gerente("333333", "moonn", "21354687" , "lug@lug", "31/08/2019", true);
            Gerente g2 = new Gerente("444444", "light", "23156489" , "gun@gun", "31/08/2018", true);

            v1.Visualizar();
            v1.SetEmail("email@contato.com");
            v1.Visualizar();

            v2.Visualizar();
            v2.SetEmail("look@aesthetic.com");
            v2.Visualizar();

            g1.Visualizar();
            g1.SetNome("Ialdo");
            g1.Visualizar();

            g2.Visualizar();
            g2.SetCancelaVenda(false);
            g2.Visualizar();
        }
    }
}