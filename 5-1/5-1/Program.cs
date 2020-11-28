using System;

namespace _5_1
{
    class Program
    {
        static void Celsiusz(int F)
        {
        int C = 5*(F - 32) / 9;
        Console.WriteLine("Jest to {0} stopni Celsiusza", C);
        Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj tempreature w stopniach Farenheita:");
        int F = int.Parse(Console.ReadLine());
        Celsiusz(F);
        }
    }
}
