using System.Diagnostics.CodeAnalysis;

namespace CustomAlgorithm.Tests
{
    public class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj) => new StudentEquilityComparer().Equals(this, (Student)obj);
        public override int GetHashCode() => new StudentEquilityComparer().GetHashCode(this);

        public int CompareTo(Student other)
        {
            //return this.Age.CompareTo(other.Age);

            if (Age > other.Age)
            {
                return 1;
            }
            else if (Age < other.Age)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class StudentEquilityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.Name.Trim().ToLower() == y.Name.Trim().ToLower() && x.Age == y.Age;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Name.Length;
        }
    }
}
