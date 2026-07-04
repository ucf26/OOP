using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _02_Student_Grade_Management_System
{
    internal class GradeBook
    {
        public string? Name { get; set; }

        readonly List<Student> _students;

        public GradeBook()
        {
            _students = new List<Student>(15);
            Name = default;
        }


        public GradeBook(string name)
        {
            _students = new List<Student>(15);
            Name = name;
        }

        public GradeBook(int capacity, string name)
        {
            _students = new List<Student>(capacity);
            Name = name;
        }


        // Adds a student to the gradebook
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        // Removes a student by ID
        public void RemoveStudent(string studentid)
        {
            for(int i=0;i<_students.Count;i++)
            {
                if (_students[i].StudentID == studentid)
                {
                    _students.RemoveAt(i);
                    return;
                }
            }
        }


        // Finds and returns a student
        public Student FindStudent(string studentid)
        {
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].StudentID == studentid)
                {
                    return _students[i];
                }
            }
            return null;
        }


        // Returns the average grade of all students
        public decimal GetClassAverage()
        {
            decimal sum = 0;
            foreach (Student student in _students)
            {
                sum += student.CalculateAverage();
            }
            return sum/_students.Count;
        }


        // Returns the top performing students
        public List<Student> GetTopStudents(int count)
        {
            _students.Sort();
            if(count < 1 ||  count >= _students.Count)
            {
                throw new Exception("Invalid Number Of Students In The Class!!");
            }
            List<Student> result = new();
            for(int i = 0; i < count; i++)
            {
                result.Add(_students[i]);
            }
            return result;
        }

        //displayAllStudents() : Shows all students and their averages
        public void DisplayAllStudents()
        {
            foreach(Student s in _students)
            {
                Console.WriteLine( s.GetStudentInfo());
            }
        }

        //getStudentsByLetterGrade(letterGrade): Returns students with specific letter grade
        public List<Student> GetStudenByLetterGrade(string lettergrade)
        {
            List<Student> result = new();

            foreach(Student s in _students)
            {
                if(s.GetLetterGrade() == lettergrade)
                {
                    result.Add(s);
                }
            }

            return result;
        } 
    }
}
