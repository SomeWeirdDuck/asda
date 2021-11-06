using System;
using static System.Math;
using System.Collections.Generic;
using System.IO;

namespace oaoaoaoa
{
    class Program
    {
        class Student
        {
            string fName;
            string lName;
            int course;
            int group;
            int rate;
            public int Gr()
            {
                return group;
            }
            public int Rt()
            {
                return rate;
            }
            public void Print()
            {
                System.Console.WriteLine("{0} {1} {2} {3} {4}", fName, lName, course, group, rate);
            }
            public Student(string f, string l, int c, int g, int r)
            {
                fName = f;
                lName = l;
                course = c;
                group = g;
                rate = r;
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("a", "a", 1, 2, 12));
            students.Add(new Student("b", "b", 1, 3, 12));
            students.Add(new Student("c", "c", 4, 2, 25));
            students.Add(new Student("d", "d", 3, 2, 107));
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Gr() == 2 && students[i].Rt() > 20) students[i].Print();
            }
        }
    }
}