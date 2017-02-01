using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    /// <summary>
    /// Student class
    /// </summary>
    class Student
    {
        public int age;
        public string name;

        public Student()
        {
            age = 18;
            name = "Sam Red";
        }

        public Student(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        
        public override string ToString()
        {
            return age + " " + name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("John", 25);
            Console.WriteLine(s.ToString());
        }
    }
}