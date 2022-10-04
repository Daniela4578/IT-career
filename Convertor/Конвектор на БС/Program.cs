using System;
using System.Collections.Generic;

namespace Конвектор_на_БС
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "d")
            {
                int n = Int32.Parse(Console.ReadLine());
                string output = Console.ReadLine();
                if (output == "b")
                {
                    Console.WriteLine(Convert.ToString(n, 2));
                }
                else if (output == "h")
                {
                    Console.WriteLine(n.ToString("X"));
                }
                else
                {
                    Console.WriteLine("Invalid put!");
                }
            }
            else if (input == "b")
            {
                string n = Console.ReadLine();
                string output = Console.ReadLine();
                if (output == "d")
                {
                    Console.WriteLine(Convert.ToInt64(n, 2));
                }
                else if (output == "h")
                {
                    Console.WriteLine(Convert.ToInt32(n, 2).ToString("X"));
                }
                else
                {
                    Console.WriteLine("Invalid put!");
                }
            }
            else if (input == "h")
            {
                string n = Console.ReadLine();
                string output = Console.ReadLine();
                if (output == "b")
                {
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(n, 16), 2));
                }
                else if (output == "d")
                {
                    Console.WriteLine(Convert.ToInt32(n, 16));
                }
                else
                {
                    Console.WriteLine("Invalid put!");
                }
            }
            else
            {
                Console.WriteLine("Invalid put!");
            }
        }
    }
}
