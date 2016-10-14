using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using RepoQuiz.Models;
using System.Collections.Generic;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class StudentRepositoryTests
    {
        [TestMethod]
        public void TestGetTenStudents()
        {
            StudentRepository sr = new StudentRepository();
            List<Student> tgts = new List<Student>();
            tgts = sr.GetTenStudents();
            CollectionAssert.AllItemsAreNotNull(tgts);
        }

    }
}
