using System;

namespace Междувалутен_конвертор
{
    class Program
    {
        static void Main(string[] args)
        {
            double broi = double.Parse(Console.ReadLine());
            string inputval = Console.ReadLine();
            string outputval = Console.ReadLine();

            if (inputval == "BNG")
            {
                if (outputval == "USD")
                { Console.WriteLine(Math.Round(broi * 0.5772, 2)); }
                else if (outputval == "EUR")
                { Console.WriteLine(Math.Round(broi * 0.5119, 2)); }
                else if (outputval == "GBP")
                { Console.WriteLine(Math.Round(broi * 0.4297, 2)); }
            }

            else if (inputval == "USD")
            {
                if (outputval == "BNG")
                { Console.WriteLine(Math.Round(broi * 1.7325, 2)); }
                else if (outputval == "EUR")
                { Console.WriteLine(Math.Round(broi * 0.8869, 2)); }
                else if (outputval == "GBP")
                { Console.WriteLine(Math.Round(broi * 0.7444, 2)); }
            }

            else if (inputval == "EUR")
            {
                if (outputval == "BNG")
                { Console.WriteLine(Math.Round(broi * 1.9535, 2)); }
                else if (outputval == "USD")
                { Console.WriteLine(Math.Round(broi * 1.1275, 2)); }
                else if (outputval == "GBP")
                { Console.WriteLine(Math.Round(broi * 0.8394, 2)); }
            }

            else if (inputval == "GBP")
            {
                if (outputval == "BNG")
                { Console.WriteLine(Math.Round(broi * 2.3273, 2)); }
                else if (outputval == "EUR")
                { Console.WriteLine(Math.Round(broi * 1.1914, 2)); }
                else if (outputval == "USD")
                { Console.WriteLine(Math.Round(broi * 1.3433, 2)); }
            }
            else
            { Console.WriteLine("Type another valuta!"); }
        }
    }
}
