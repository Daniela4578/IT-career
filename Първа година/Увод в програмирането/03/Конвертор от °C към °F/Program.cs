using System;

namespace Конвертор_от__C_към__F
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine(C + "°C");
            double F = C*9/5 + 32;
            Console.WriteLine("{0}°F.", F);
        }
    }
}
