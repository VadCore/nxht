using System;
using NixSolHT1.Students;

namespace Nxsht
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rect = new Rectangle(1, 1, 6, 4);

            //var circle = new Circle(1, 1, 5);

            //var triangle = new Triangle(1, 1, 6, 4, -3, -7);

            //triangle.Scale(5);

            //triangle.PrintInfo();

            var cityDistance = new CityDistance();

            Console.WriteLine("CityDistance result: " + cityDistance.GetDistanceLinq("Kharkov", "Pisochyn"));

            Console.WriteLine("CityDistanceLINQ result: " + cityDistance.GetDistance("Kharkov", "Pisochyn"));

            //var journal = new Journal();

            //var harry = new Student { Name = "Harry", SurName = "Potter", Group = "Griffindor" };
            //var hermiona = new Student { Name = "Hermiona", SurName = "Granger", Group = "Griffindor" };
            //var ron = new Student { Name = "Ron", SurName = "Weasley", Group = "Griffindor" };
            
            //var draco = new Student { Name = "Draco", SurName = "Malfoy", Group = "Slytherin" };
            //var goyle = new Student { Name = "Gregory", SurName = "Goyle", Group = "Slytherin" };
            //var crabbe = new Student { Name = "Vincent", SurName = "Crabbe", Group = "Slytherin" };
            


            //journal.AddStudent(harry);
            //journal.AddStudent(hermiona);
            //journal.AddStudent(ron);

            //journal.AddMarkToStudent(ron, 20);
            //journal.AddMarkToStudent(ron, 10);
            //journal.AddMarkToStudent(ron, 30);
            //journal.AddMarkToStudent(hermiona, 80);
            //journal.AddMarkToStudent(hermiona, 98);
            //journal.AddMarkToStudent(hermiona, 100);

            //journal.AddStudent(draco);
            //journal.AddStudent(crabbe);
            //journal.AddStudent(goyle);

            //journal.AddMarkToStudent(draco, 95);
            //journal.AddMarkToStudent(crabbe, 80);
            //journal.AddMarkToStudent(goyle, 75);

            //journal.GetAvrMarkForFaculty("Griffindor");

            Console.ReadLine();
        }
    }
}
