namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("12345678910", "Vitor", "40028923", "cortador@degrama.com", "31/08/2023");
            Cliente c2 = new Cliente("01987654321", "Allan", "40028922", "carro@carro.com", "31/08/2022");

            c1.Visualizar();
            c2.SetEmail("carro@rebaixo.com");
            c2.Visualizar();

            PessoaFisica pf1 = new PessoaFisica("123456789", "Rodrigo", "40028923", "cortador@degrama.com", "31/08/2023", "12345678910");
            PessoaFisica pf2 = new PessoaFisica("123456789", "Rodrigo", "40028923", "cortador@degrama.com", "31/08/2023", "12345678910");

            PessoaJuridica pj1 = new PessoaJuridica("019876543", "Goes", "40028923", "cortador@degrama.com", "31/08/2023", "12.345.789/0001-10");
            PessoaJuridica pj2 = new PessoaJuridica("019876543", "Goes", "40028923", "cortador@degrama.com", "31/08/2023", "12.345.789/0001-10");

            pf1.Visualizar();
            pf1.SetEmail("email@contato.com");
            pf1.Visualizar();

            pj1.Visualizar();
            pj1.SetEmail("look@aesthetic.com");
            pj1.Visualizar();

            pf2.Visualizar();
            pf2.SetNome("Fabio");
            pf2.Visualizar();

            pj2.Visualizar();
            pj2.SetTelefone("xoxo-xoxo");
            pj2.Visualizar();
        }
    }
}