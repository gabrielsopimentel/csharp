namespace Exercicio3
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Produto p1 = new Produto(1, "asd", 12.0f, 15.0f, 4);
            Produto p2 = new Produto(2, "dsa", 16.0f, 19.0f, 7);

            p1.Visualizar();
            p1.SetDescricao("xyz");
            p1.Visualizar();
            p2.Visualizar();
        }
    }
}