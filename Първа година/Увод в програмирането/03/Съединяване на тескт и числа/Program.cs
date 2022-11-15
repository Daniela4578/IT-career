using System;

namespace Съединяване_на_тескт_и_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, а {2}-years old person from {3}.", firstName, lastName, age, town );
        }
    }
}
