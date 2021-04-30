using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace NixSolHT1.Students
{
    public class Student : IEquatable<Student>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Group { get; set; }
        public string FullName => $"{Name} {SurName}";

        public static bool operator == (Student first, Student second)
        {
               return !(first is null ^ second is null)
                && (first is null || (first.Name, first.SurName, first.Group)
                == (second.Name, second.SurName, second.Group));
        }

        public static bool operator !=(Student first, Student second) =>
            !(first == second);

        public bool Equals([AllowNull] Student other) => this == other;
        public override bool Equals(object obj) =>
            Equals(obj as Student);

        public override int GetHashCode()=> HashCode.Combine(Name, SurName, Group);

        
    }
}
