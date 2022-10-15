using System;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 1; number <= 10; number++)
                Console.WriteLine(new string('*', number));
        }
    }
}
