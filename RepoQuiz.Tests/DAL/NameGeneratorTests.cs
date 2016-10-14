using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoQuiz.DAL;
using System.Threading;

namespace RepoQuiz.Tests.DAL
{
    [TestClass]
    public class NameGeneratorTests
    {
        [TestMethod]
        public void TestFirstNameReturned()
        {
            NameGenerator ng = new NameGenerator();
            var resultName = ng.GetFirstName();
            Assert.IsNotNull(resultName);
        }

        [TestMethod]
        public void TestLastNameReturned()
        {
            NameGenerator ng = new NameGenerator();
            var resultName = ng.GetLastName();
            Assert.IsNotNull(resultName);
        }

        [TestMethod]
        public void TestMajorReturned()
        {
            NameGenerator ng = new NameGenerator();
            var resultName = ng.GetMajor();
            Assert.IsNotNull(resultName);

        }

    }
}
