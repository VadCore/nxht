using System;

namespace NixSolHomeTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(1, 1, 6, 4);

            var circle = new Circle(1, 1, 5);

            var triangle = new Triangle(1, 1, 6, 4, -3, -7);

            triangle.Scale(5);

            triangle.PrintInfo();

            var cityDistance = new CityDistance();

            Console.WriteLine("CityDistance result: " + cityDistance.GetDistanceLinq("Kharkov", "Pisochyn"));

            Console.WriteLine("CityDistanceLINQ result: " + cityDistance.GetDistance("Kharkov", "Pisochyn"));

            Console.ReadLine();
        }
    }
}
