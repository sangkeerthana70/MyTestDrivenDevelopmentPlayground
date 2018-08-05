using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FindTriangleType
{
    class FindTriangleTest
    {
        [TestCase(10,10,10)]
        [TestCase(20,10,20)]
        [TestCase(40,20,40)]
        public void Is_Triangle(int a, int b, int c) 
        {
            string isTriangle = FindTriangle.TriangleType(a, b, c);
            Assert.AreEqual("It is a triangle", isTriangle);
            Console.WriteLine(isTriangle);
        }

        [TestCase(10, 30, 80)]
        [TestCase(10, 40, 80)]
        [TestCase(40, 30, 90)]
        public void Is_Not_Triangle(int x, int y, int z)
        {
            string isNotTriangle = FindTriangle.TriangleType(x, y, z);
            Assert.AreEqual("It is not a triangle", isNotTriangle);
            Console.WriteLine(isNotTriangle);

        }

        
    }
}
