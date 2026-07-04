using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Student_Grade_Management_System
{
    internal class Student : IComparable<Student>
    {
        public string? StudentID { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }


        // Subject names (keys) and grades (values)
        Dictionary<string, decimal> Grades;


        public Student(string id, string name, string email)

        {
            StudentID = id;
            Name = name;
            Email = email;
            Grades = new Dictionary<string, decimal>();
        }
        //public Dictionary<string, decimal> Grades { get; set; }


        // Add or update a grade for a subject
        public void AddGrade(string subject, decimal grade)
        {
            Grades.Add(subject.ToUpper(), grade);
        }


        // Returns the grade for a specific subject
        public decimal GetGrade(string subject)
        {
            return Grades[subject.ToUpper()];
        }

        // Returns the average of all grades
        public decimal CalculateAverage()
        {
            int cnt = 0;
            decimal tot = 0;
            foreach(var g in Grades)
            {
                cnt++;
                tot += g.Value;
            }
            return (tot * 1.0m) / cnt;
        }



        // Returns letter grade based on average (A, B, C, D, F)
        public string GetLetterGrade()
        {
            decimal g=CalculateAverage();
            decimal Percent = g*100/(decimal)Grades.Count;
            if (Percent >= 85)
            {
                return "A";
            }
            if(Percent >= 75)
            {
                return "B";
            }
            if(Percent >= 60)
            {
                return "C";
            }
            if(Percent >= 50)
            {
                return "E";
            }
            return "F";
        }

        // Returns formatted student information with all grades
        public string GetStudentInfo()
        {
            //return $"Student ID: {this.StudentID}\nStudent Full Name:{this.Name}\nStudent Email: {this.Email}\nStudent Letter Grade: {this.GetLetterGrade()}\n";
            StringBuilder S = new StringBuilder();
            S.Append($"Student ID: {this.StudentID}\n");
            S.Append($"Student Name: {this.Name}\n");
            S.Append($"Student Email: {this.Email}\n");
            S.Append($"Grades:\n");
            foreach( var g in Grades) 
            {
                S.Append($"\t{g.Key}: {g.Value}");
            }
            S.Append("\n");
            S.Append($"Average: {this.CalculateAverage():F2} ({this.GetLetterGrade()})\n");
            return S.ToString();
        }

        public int CompareTo(Student? other)
        {
            if(this.CalculateAverage() > other.CalculateAverage())
            {
                return -1;
            }
            else if (this.CalculateAverage() < other.CalculateAverage())
            {
                return 1;
            }
            return 0;
        }
    }


    //internal static class StudentComaparer : IComparer<Student>
    //{
    //    public int Compare(Student? x, Student? y)
    //    {
    //        return x.CalculateAverage() <= y.CalculateAverage() : 
    //    }
    //}
}
