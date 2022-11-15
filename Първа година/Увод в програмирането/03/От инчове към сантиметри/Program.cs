using System;

namespace От_инчове_към_сантиметри
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете инчовете: ");
            double inch = double.Parse(Console.ReadLine());
            double cm = (inch * 2.54);
            Console.WriteLine("см = {0}", cm);
        }
    }
}
