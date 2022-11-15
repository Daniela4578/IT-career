using System;

namespace Конвертор_от_USD_към_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BNG = Math.Round(USD * 1.79549, 2);
            Console.WriteLine(BNG + " " + "BNG");
        }
    }
}
