using System;

namespace _5_5
{
    class Program
    {
        static void Rysuj(int dl, int sz, char zn)
        {
            char[,] tab = new char[dl, sz];
            for (int j=0; j<sz;j++)
            {
                for (int i=0;i<dl;i++)
                {
                    tab[i, j] = zn;
                }
            }
            for (int j = 0; j < sz; j++)
            {
                for (int i = 0; i < dl; i++)
                {
                    Console.Write(tab[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < dl; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    Console.Write(tab[i, j]);
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj wymiary prostokata\ndlugosc: ");
            int dl = int.Parse(Console.ReadLine());
            Console.Write("szerokosc:");
            int sz = int.Parse(Console.ReadLine());
            Console.Write("Znak, ktorym prostokat ma byc wypelniony: ");
            char zn = char.Parse(Console.ReadLine());
            Rysuj(dl, sz, zn);
        }
    }
}
