using System;

namespace _5_2
{
    class Program
    {
        static bool Tester(double a, double b, double x)
        {
            if (a>b)
            {
                if (x<=a && x>=b)
                {
                    return true;
                }
            }
            if (a<b)
            {
                if (x <= b && x >= a)
                {
                    return true;
                }
            }
            if (a == b && x == a)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby a i b okreslajace przedzial, oraz liczbe x");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            bool wynik = Tester(a, b, x);
            if (wynik == true)
            {
                Console.WriteLine("X = {0} nalezy do przedzialu otwartego ({1},{2})", x, a, b);
            }
            else
            {
                Console.WriteLine("X = {0} nie nalezy do przedzialu otwartego ({1},{2})", x, a, b);
            }
            Console.ReadKey();
        }
    }
}
