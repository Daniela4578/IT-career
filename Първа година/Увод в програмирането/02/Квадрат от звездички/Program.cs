using System;

namespace SquareOfNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            if (n > 2 && n <= 100)
            {
                var stars = new string('*', n);
                var space = new string(' ', n - 2);
                var star = new string("*");
                Console.WriteLine(stars);
                for ( int i = 1; i <= n-2; i++)
                { Console.WriteLine(star + space + star); } 
                    Console.WriteLine(stars);
             }
             else
               { Console.WriteLine("2 < n <= 100"); }

        }
    }
}
