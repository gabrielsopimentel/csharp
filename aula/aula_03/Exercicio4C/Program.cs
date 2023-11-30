namespace Exercicio4C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;

            Console.Write("Digite a primeira palavra: ");
            palavra1 = Console.ReadLine();

            Console.Write("Digite a segunda palavra: ");
            palavra2 = Console.ReadLine();

            Console.Write("Digite a terceira palavra: ");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                //verificando se é vertebrado ou invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    //verificando se é ave ou mamifero
                    if (palavra2.Equals("ave"))
                    {
                        //verificando se é carnivoro ou onivoro
                        if (palavra3.Equals("carnivoro"))
                        {
                            Console.WriteLine("aguia");
                        }
                        else { Console.WriteLine("pomba"); }
                    }
                    else
                    {
                        //verificando se é onivoro ou herbivoro
                        if (palavra3.Equals("onivoro"))
                        {
                            Console.WriteLine("homem");
                        }
                        else { Console.WriteLine("vaca"); }
                    }
                }
                else
                {
                    //verificando se é inseto ou anelideo
                    if (palavra2.Equals("inseto"))
                    {
                        //verificando se é hematofago ou herbivoro
                        if (palavra3.Equals("hematofago"))
                        {
                            Console.WriteLine("pulga");
                        }
                        else { Console.WriteLine("lagarta"); }
                    }
                    else
                    {
                        //verificando se é hematofago ou onivoro
                        if (palavra3.Equals("anelideo"))
                        {
                            Console.WriteLine("sanguessuga");
                        }
                        else { Console.WriteLine("minhoca"); }
                    }
                }
            }
            else
            {
                Console.Write("As palavras não podem ser nulas");
            }
        }
    }
}