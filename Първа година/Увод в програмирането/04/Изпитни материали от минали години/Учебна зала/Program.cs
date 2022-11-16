using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            if (2 < h && w < 101)
            {
                if (h <= w)
                {
                    double w1 = (w * 100 / 120);
                    double h1 = ((h * 100 - 100) / 70);
                    double mesta = Math.Round(w1 * h1) - 3;
                    Console.WriteLine(mesta);
                    
                }
                else
                { Console.WriteLine("3 <= h <= w <= 100"); }
            }
            else
            { Console.WriteLine("3 <= h <= w <= 100"); }
        }
    }
}
