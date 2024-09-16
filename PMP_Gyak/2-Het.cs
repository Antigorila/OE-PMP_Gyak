using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PMP_Gyak
{
    internal class _2_Het
    {
        private static void F6()
        {
            Console.Write("Adj meg egy pozitív egész számot: ");
            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0)
            {
                Console.WriteLine($"{N} páros.");
            }
            else
            {
                Console.WriteLine($"{N} páratlan.");
            }

            int divisorCount = 0;
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    divisorCount++;
                }
            }
            Console.WriteLine($"{N}-nek {divisorCount} valódi pozitív osztója van.");

            if (divisorCount == 0)
            {
                Console.WriteLine($"{N} prímszám.");
            }
            else
            {
                Console.WriteLine($"{N} összetett szám.");
            }
        }

        private static void F8()
        {
            int size = 9;

            Console.Write("    ");
            for (int i = 1; i <= size; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();

            for (int i = 1; i <= size; i++)
            {
                Console.Write($"{i,2} |");
                for (int j = 1; j <= size; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }
        }

        private static void F9()
        {
            Console.Write("Add meg a másodpercet: ");
            int sc = int.Parse(Console.ReadLine());

            while (sc >= 0)
            {
                Console.Clear();

                int minutes = sc / 60;
                int seconds = sc % 60;
                Console.WriteLine($"Perc:Másodperc: {minutes}:{seconds:D2}");

                if (sc == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Az idő lejárt!");
                    Console.Beep();
                    break;
                }

                Thread.Sleep(1000);

                sc--;
            }
        }
    }
}
