namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            //Adicionar elementos
            notas.Add(7.0);
            notas.Add(5.0);
            notas.Add(4.0);
            notas.Add(7.0);
            notas.Add(10.0);

            //Listar todos os elementos
            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            //Indice de um elemnto
            Console.WriteLine("Posição da nota 4.0: " + notas.IndexOf(4.0));

            //Checar se o elemento existe
            Console.WriteLine("A nota existe?: " + notas.Contains(4.0));

            //deletar elemnto
            notas.Remove(7.0);

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine("A nota existe?: " + notas.Count);

            //Ordenação crescente
            notas.Sort();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            //Ordenação decrescente
            notas.Reverse();

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }

            //Alteração de nota
            notas[0] = 9.0;

            foreach (double nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
    }
}