﻿using System;

namespace Лице_на_правоъгълник_в_равнината
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1,x2) - Math.Min(x1,x2);
            double heigh = Math.Max(y1, y2) - Math.Min(y1, y2);
            double area = width * heigh;
            double perimeter = 2 * (width + heigh);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
