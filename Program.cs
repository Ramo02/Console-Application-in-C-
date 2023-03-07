using System;

namespace TriangleInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinates of Point A (x,y): ");
            string[] pointA = Console.ReadLine().Split(',');
            double xA = double.Parse(pointA[0]);
            double yA = double.Parse(pointA[1]);

            Console.WriteLine("Enter coordinates of Point B (x,y): ");
            string[] pointB = Console.ReadLine().Split(',');
            double xB = double.Parse(pointB[0]);
            double yB = double.Parse(pointB[1]);

            Console.WriteLine("Enter coordinates of Point C (x,y): ");
            string[] pointC = Console.ReadLine().Split(',');
            double xC = double.Parse(pointC[0]);
            double yC = double.Parse(pointC[1]);

            double AB = Math.Round(Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2)), 2);
            double BC = Math.Round(Math.Sqrt(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2)), 2);
            double AC = Math.Round(Math.Sqrt(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2)), 2);

            Console.WriteLine($"Side AB: {AB}");
            Console.WriteLine($"Side BC: {BC}");
            Console.WriteLine($"Side AC: {AC}");

            bool isEquilateral = AB == BC && BC == AC;
            bool isIsosceles = AB == BC || BC == AC || AC == AB;
            bool isRight = Math.Pow(BC, 2) - (Math.Pow(AB, 2) + Math.Pow(AC, 2)) <= 0.0001;

            Console.WriteLine($"Is it an equilateral triangle? {isEquilateral}");
            Console.WriteLine($"Is it an isosceles triangle? {isIsosceles}");
            Console.WriteLine($"Is it a right triangle? {isRight}");

            double perimeter = Math.Round(AB + BC + AC, 2);
            Console.WriteLine($"Perimeter: {perimeter}");

            Console.WriteLine("Even numbers from 0 to perimeter:");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
