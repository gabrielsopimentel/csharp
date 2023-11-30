namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? vert, animal, food;

            Console.Write("É vertebrado ou invertebrado?: ");
            vert = Console.ReadLine().ToLower();

            Console.Write("Qual é o tipo do animal?: ");
            animal = Console.ReadLine().ToLower();

            Console.Write("Qual tipo de comida ?: ");
            food = Console.ReadLine().ToLower();

            if (vert.Equals("vertebrado"))
            {
                if (animal.Equals("ave"))
                {
                    if (food.Equals("carnivoro"))
                        Console.WriteLine("Águia");
                    else if (food.Equals("onivoro"))
                    {
                        Console.WriteLine("Pomba");
                    }

                }
                else if (animal.Equals("mamifero"))
                {
                    if (food.Equals("onivoro"))
                        Console.WriteLine("Homem");
                    else if (food.Equals("herbivoro"))
                    {
                        Console.WriteLine("Vaca");
                    }
                }
            }
            else if (vert.Equals("invertebrado"))
            {
                if (animal.Equals("inseto"))
                {
                    if (food.Equals("hematofago"))
                        Console.WriteLine("Pulga");
                    else if (food.Equals("herbivoro"))
                    {
                        Console.WriteLine("Lagarta");
                    }

                }
                else if (animal.Equals("anelideo"))
                {
                    if (food.Equals("hematofago"))
                        Console.WriteLine("Sanguessuga");
                    else if (food.Equals("onivoro"))
                    {
                        Console.WriteLine("Minhoca");
                    }
                }
            }


        }
    }
}