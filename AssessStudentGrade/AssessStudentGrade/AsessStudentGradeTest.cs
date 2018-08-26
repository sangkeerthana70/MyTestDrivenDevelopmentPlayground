using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessStudentGrade
{
    class AsessStudentGradeTest
    {
        AssessStudentGrade grade;
        [SetUp]
        public void Setup()
        {
            grade = new AssessStudentGrade();
        }
        [TestCase(97)]
        [TestCase(98)]
        [TestCase(99)]
        [TestCase(100)]
        [TestCase(0)]
        [TestCase(-100)]
        public void InputIntReturnsAString(int score)
        {
            var actual = grade.CalcGrade(score);
            var expected = "A+";
            Console.WriteLine(actual.GetType());
            Assert.AreEqual(actual.GetType(), expected.GetType(), "Result should be a string");
            
        }
        [TestCase(97)]
        [TestCase(98)]
        [TestCase(99)]
        [TestCase(100)]
        public void IntGreaterThan97ReturnsGradeAPlus(int score)
        {
            var actual = grade.CalcGrade(score);
            var expected = "A+";
            Console.WriteLine(actual);
            Assert.IsTrue(actual == expected, "Actual and expected are different");

        }
        [TestCase(92)]
        [TestCase(93)]
        [TestCase(94)]
        [TestCase(95)]
        [TestCase(96)]
        [TestCase(97)]
        [TestCase(85)]
        public void Range92to97ReturnsGradeA(int score)
        {
            var actual = grade.CalcGrade(score);
            var expected = "A";
            Console.WriteLine(actual);
            Assert.IsTrue(actual == expected, "actual and expected are different");
        }

        [TestCase(85)]
        [TestCase(86)]
        [TestCase(87)]
        [TestCase(88)]
        [TestCase(89)]
        [TestCase(90)]
        [TestCase(91)]
        [TestCase(84)]
        [TestCase(92)]
        public void Range85to91ReturnsGradeB(int score)
        {
            var actual = grade.CalcGrade(score);
            var expected = "B";
            Console.WriteLine(actual);
            Assert.AreEqual(actual, expected, "Result should be a string");
        }


    }
}
