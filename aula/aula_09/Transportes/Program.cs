﻿namespace Transportes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transporte t1 = new Transporte(5);

            t1.Visualizar();

            Console.WriteLine();

            Terrestre t2 = new Terrestre(4, 4, 100);

            t2.Visualizar();

            Automovel a1 = new Automovel(10, 10, 280, "verde", 1, "FVW-6989", 7);

            a1.Visualizar();
        }
    }
}