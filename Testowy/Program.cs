using System;
using System.Numerics;

namespace Testowy
{
    class Program
    {
        static void Main(string[] args)
        {
            poczatek:

            Console.WriteLine("Generetor prostokątów");
            Console.WriteLine("---------------------\n");

            szerokosc:
            Console.Write("Podaj szerokość: ");
            string xs = Console.ReadLine();

            BigInteger cleanxs = 0;
            while (!BigInteger.TryParse(xs, out cleanxs))
            {
                Console.WriteLine("To jest błędna warość. Proszę wprowadzić poprawną!");
                goto szerokosc;
            }
            //decimal x = decimal.Parse(xs);
            BigInteger x = BigInteger.Parse(xs);

            wysokosc:
            Console.Write("Podaj wysokość: ");
            string ys = Console.ReadLine();

            BigInteger cleanys = 0;
            while (!BigInteger.TryParse(ys, out cleanxs))
            {
                Console.WriteLine("To jest błędna warość. Proszę wprowadzić poprawną!");
                goto wysokosc;
            }
            //int y = int.Parse(ys);
            BigInteger y = BigInteger.Parse(ys);

            wybor:

            Console.WriteLine("Wciśnij 1 by wypełnić, lub 2 aby pokazać obręb:");
            string postacs = Console.ReadLine();

            if (postacs != "1" && postacs != "2")
            {
                Console.WriteLine("Wprowadzona wartość jest niepoprawna!");
                goto wybor;
            }

            int postac = int.Parse(postacs);

            if (postac == 1)
            {
                Console.WriteLine();
                for (BigInteger i = 0; i < y; i++)
                {
                    for (BigInteger j = 0; j < x; j++)
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
                for (BigInteger j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                for (BigInteger i = 0; i < y - 2; i++)
                {
                    Console.Write("* ");
                    for (BigInteger j = 0; j < x - 2; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("* ");
                    Console.WriteLine();
                }

                for (BigInteger j = 0; j < x; j++)
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
            else
            {
                Console.Clear();
                goto poczatek;
            }
        }
    }
}