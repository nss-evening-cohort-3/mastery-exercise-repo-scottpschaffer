using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepoQuiz.DAL
{
    public class NameGenerator
    {
        // This class should be used to generate random names and Majors for Students.
        // This is NOT your Repository
        // All methods should be Unit Tested :)

        Random rnd1 = new Random();

        public string GetFirstName()
        {
            string[] fNameList = new string[] { "Mark", "Mary", "Nicholas", "Nancy", "Alan", "Anita", "Brian", "Bernice", "Charles", "Karen", "Eliot", "Francine", "Gregory", "Heidi", "John", "Joanne", "Keith", "Lawrence", "Pauline", "Richard" };
            return fNameList[rnd1.Next(0, 19)];
        }

        public string GetLastName()
        {
            string[] lNameList = new string[] { "McDonald", "Anderson", "Schwartz", "Nolen", "Hancock", "Washington", "Baggins", "Cohen", "Brewster", "Simpson", "Edwards", "Frewer", "Gonzales", "Hendricks", "Robinson", "Yarrow", "Klein", "Torrance", "Wiggins", "Ulrich" };
            //Random rnd2 = new Random();
            return lNameList[rnd1.Next(0, 19)];
        }

        public string GetMajor()
        {
            string[] majorList = new string[] { "Sports Medicine", "Physics", "Chemistry", "Criminal Law", "Accounting", "Basket Weaving", "Computer Science", "Political Science", "Mechanical Engineering", "English", "Psychology", "Business", "Biology", "Nursing", "Economics", "Fine Arts", "Pharmacy", "Education", "Astonomy", "Philosophy" };
            //Random rnd3 = new Random();
            return majorList[rnd1.Next(0, 19)];
        }
    }
}