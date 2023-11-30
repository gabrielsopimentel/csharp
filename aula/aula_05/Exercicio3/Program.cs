namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int num, somapri = 0, somasec = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Digite o [{i}][{j}]: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    matriz[i, j] = num;
                }
            }

            Console.Write("Elementos da Diagonal Principal: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i,j] + " ");
                        somapri += matriz[i, j];
                    }
                }
            }
            Console.Write("\n");

            Console.Write("Elementos da Diagonal Secundária: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if ((i + j) == matriz.GetLength(0) - 1)
                    {
                        Console.Write(matriz[i,j] + " ");
                        somasec += matriz[i, j];
                    }
                }
            }
            Console.Write("\n");

            Console.WriteLine($"Soma dos Elementos da Diagonal Principal: {somapri}");
            Console.WriteLine($"Soma dos Elementos da Diagonal Secundária: {somasec}");
        }
    }
}