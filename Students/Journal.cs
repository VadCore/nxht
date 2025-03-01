﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NixSolHT1.Students
{
    public class Journal
    {
        public Dictionary<Student, List<int>> MarksOfStudents = new Dictionary<Student, List<int>>();

        public void AddStudent(Student stud)
        {
            if(stud is null || !(stud is Student))
                Console.WriteLine("This object is not valid!");

            if (MarksOfStudents.ContainsKey(stud))
                Console.WriteLine($"Student {stud.FullName} has already been added to the journal!");

            else
            {
                MarksOfStudents.Add(stud, new List<int>());
                Console.WriteLine($"Student {stud.FullName} added successfully!");
            }
        }

        public void AddMarkToStudent(Student stud, int mark)
        {            
            if (!(mark >= 0 && mark <= 100))
                Console.WriteLine("Error. the mark must be in range 0 - 100");

            if (stud == null || !MarksOfStudents.ContainsKey(stud))
                Console.WriteLine("Such a student was not found in the journal");

            else
            {
                MarksOfStudents.Where(s => s.Key == stud).SingleOrDefault().Value.Add(mark);
                Console.WriteLine($"Student {stud.FullName} get mark {mark}");
            }
                
        }

        public void GetAvrMarkByStudent(Student stud)
        {
            if (stud == null || !MarksOfStudents.ContainsKey(stud))
            {
                Console.WriteLine("Student not found or null!");
            }

            else if (MarksOfStudents.Where(s => s.Key == stud).FirstOrDefault().Value.Count != 0)
            {
                Console.WriteLine($"The student {stud.FullName} no ratings yet.");

                var avrMark = MarksOfStudents.Where(s => s.Key == stud).FirstOrDefault().Value.Average();
                Console.WriteLine($"Average mark for student {stud.FullName} = {avrMark}");
            }

            else
            {
                Console.WriteLine($"The student {stud.FullName} no ratings yet.");
            }
        }

        public void GetUnderperformingStudents()
        {
            int minGoodMark = 60;

            Console.WriteLine("Underperforming students list:");

            foreach(var s in MarksOfStudents)
                if (s.Value.Count > 0 && s.Value.Average() < minGoodMark)
                    Console.WriteLine(s.Key.FullName);
            
        }

        public void GetAvrMarkForFaculty(string faculty)
        {
            if (MarksOfStudents.Any(x => x.Key.Group.ToLower() == faculty.ToLower() && x.Value.Count > 0))
            {
                var avrFacultyMark = Math.Round(MarksOfStudents
                                .Where(f => f.Key.Group.ToLower() == faculty.ToLower())
                                .SelectMany(marks => marks.Value)
                                .Average());

                Console.WriteLine($"Average marks in faculty {faculty} = {avrFacultyMark}");
            }
            else
                Console.WriteLine("Sorry this faculty have not marks or not found!");
        }

    }
}