using System;

namespace _5_4_a
{
    class Program
    {  
        static int[] Mnoz(int[] tab, int m)
        {
            int[] tab2 = new int[tab.Length];
            for (int i = 0; i<tab.Length; i++)
            {
                tab2[i] = tab[i] * m;
            }
            return tab2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj elemtny tablicy \nrozmiar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj elementy które mają być zawarte w tablicy");
            int[] tab = new int[n];
            for (int i=0; i<n;i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Podaj mnożnik tablicy: ");
            int m = int.Parse(Console.ReadLine());
            int[] table= Mnoz(tab, m);
            Console.Write("Po przemnożeniu powstala tablica: ");
            for (int i=0;i<n;i++)
            {
                Console.Write(table[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
