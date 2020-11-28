using System;

namespace _5_3
{
    class Program
    {
        static void Przes(ref double a, ref double b, double xw, double xy)
        {
            a = a + xw;
            b = b + xy;
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj wspolrzedne punktu A \nX =");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Y =");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Podaj wspolrzedne wektora przesuniecia \nX = ");
            double xw = double.Parse(Console.ReadLine());
            Console.Write("Y =");
            double yw = double.Parse(Console.ReadLine());
            Przes(ref x,ref y, xw, yw);
            Console.WriteLine("Wspolrzedne punktu po przesunieciu to ({0},{1})", x, y);
            Console.ReadKey();
            
        }
    }
}
