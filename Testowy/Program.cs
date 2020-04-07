using System;

namespace Testowy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Generetor prostokątów");
            Console.WriteLine("---------------------\n");

            Console.Write("Podaj szerokość: ");
            string xs = Console.ReadLine();
            Console.Write("Podaj wysokość: ");
            string ys = Console.ReadLine();

            int x = int.Parse(xs);
            int y = int.Parse(ys);


            Console.WriteLine("Wciśnij 1 by wypełnić, lub 2 aby pokazać obręb:");
            string postacs = Console.ReadLine();

            if (postacs != "1" && postacs != "2")
            {
                Console.WriteLine("Wprowadzona wartość jest niepoprawna!");
            }

            int postac = int.Parse(postacs);

            if (postac == 1)
            {
                Console.WriteLine();
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            if (postac == 2)
            {
                Console.WriteLine();
                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                for (int i = 0; i < y - 2; i++)
                {
                    Console.Write("* ");
                    for (int j = 0; j < x - 2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("* ");
                    Console.WriteLine();
                }

                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Naciśnij 'n' i Enter by zamknąć aplikację, lub dowolny inny klawisz i Enter by kontynuować:");
            if (Console.ReadLine() == "n")
            {
                return;
            }
        }
    }
}