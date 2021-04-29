using System;
using System.Collections.Generic;
using System.Text;

namespace NixSolHT1.Students
{
    public class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Group { get; set; }

        public static bool operator == (Student first, Student second)
        {
            if(!(first is null || second is null))
                return (first.Name, first.SurName, first.Group) == (second.Name, second.SurName, second.Group);

            return false;
        }

        public static bool operator !=(Student first, Student second) =>
            !(first == second);

        public override bool Equals(object obj) =>
            obj is Student otherStud && this == otherStud;

        public override int GetHashCode()=> HashCode.Combine(Name, SurName, Group);
    }
}
