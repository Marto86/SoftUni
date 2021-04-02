using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace class_and_objects
{
    public class Student
    {
        public string name;
        public int age;
        public string[] skils;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(value: "How manyy students in Softuni?");
            int n = int.Parse(s: Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }

            for (int i = 0; i < n; i++)
            {
                PrintStudent(student: students[index: i]);
            }
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name -> {student.name} ->age -> {student.age} -> skills -> {string.Join("," ,student.skils)} ");
        }

        static Student ReadStudent()
        {
            Student newStudent = new Student();
            Console.WriteLine("Enter name");
            newStudent.name = Console.ReadLine();
            Console.WriteLine("Enter age");
            newStudent.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter skills");
            newStudent.skils = Console.ReadLine().Split();
            return newStudent;
        }
    }
    
}
