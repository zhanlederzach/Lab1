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
        public int course;

        // консттруктор студента
        public Student()
        {
            age = 18;
            name = "Sam Red";
            course = 2;
        }

        // конструктор студента с тремя аргументами
        public Student(string name, int age, int course)
        {
            this.age = age;
            this.name = name;
            this.course = course;
        }
        // переписываем метод в строку
        public override string ToString()
        {
            return age + " " + name + " " + course;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // создаем объект класса студент

            //Student s = new Student("John", 25, 2);

            Student s = new Student();

            s.name = Console.ReadLine();
            s.age = int.Parse(Console.ReadLine());
            s.course = int.Parse(Console.ReadLine());

            Console.WriteLine(s.ToString());
        }
    }
}