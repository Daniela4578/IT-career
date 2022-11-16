using System;

namespace Периметър_и_лице_на_кръг
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.Round(Math.PI * r * r, 2);
            double perimeter = Math.Round(2 * Math.PI * r, 2);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = " + perimeter);
        }
    }
}
