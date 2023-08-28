namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float[,] notas = new float[10, 4];
            float[] medias = new float[2];
            float nota;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    Console.Write($"Insira a nota {j + 1}º do aluno {i + 1}: ");
                    nota = Convert.ToSingle(Console.ReadLine());
                    notas[i, j] = nota; 
                }

            }

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    medias[i] += notas[i, j];
                }
                medias[i] = medias[i] / notas.GetLength(1);
            }

            foreach (float media in medias)
            {
                Console.Write($"| {media:f1} ");
            }
                Console.Write("|");
        }
    }
}