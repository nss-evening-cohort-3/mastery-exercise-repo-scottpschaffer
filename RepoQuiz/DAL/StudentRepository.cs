using RepoQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace RepoQuiz.DAL
{
    public class StudentRepository
    {
        public StudentContext Context { get; set; }

        public StudentRepository()
        {
            Context = new StudentContext();
        }

        public StudentRepository(StudentContext _context)
        {
            Context = _context;
        }

        public List<Student> GetStudents()
        {
            return Context.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();
        }

        public Student GetStudentById(int i)
        {
            Student s = Context.Students.FirstOrDefault(a => a.StudentID == i);
            return s;
        }

        public List<Student> GetTenStudents()
        {
            NameGenerator ng = new NameGenerator();
            List<Student> st = new List<Student>();

            for (var i = 0; i < 10; i++)
            {
                Student s1 = new Student();
                s1.StudentID = (i + 1);
                s1.FirstName = ng.GetFirstName();
                Thread.Sleep(1000);
                s1.LastName = ng.GetLastName();
                Thread.Sleep(1000);
                s1.Major = ng.GetMajor();
                st.Add(s1);
            }
            return st;
        }
    }
}