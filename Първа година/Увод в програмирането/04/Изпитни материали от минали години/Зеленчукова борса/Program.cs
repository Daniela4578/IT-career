using System;

namespace Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablekg = double.Parse(Console.ReadLine());
            double fruitkg = double.Parse(Console.ReadLine());
            int vegetablecena = int.Parse(Console.ReadLine());
            int fruitcena = int.Parse(Console.ReadLine());
            if ((0.00<=vegetablekg && vegetablekg <=100.00) && 
                (0.00 <= fruitkg && fruitkg <= 100.00) &&
                (0.00 <= vegetablecena && vegetablecena <= 100.00) &&
                (0.00 <= fruitcena && fruitcena <= 100.00))
            {
                double vegetablecost = vegetablekg * vegetablecena;
                double fruitcost = fruitkg * fruitcena;
                double costlv = vegetablecost + fruitcost;
                double costeu = Math.Round(costlv / 1.94, 2);
                Console.WriteLine(costeu);
            }
            else
                { Console.WriteLine("Not valable"); }
        }
    }
}
