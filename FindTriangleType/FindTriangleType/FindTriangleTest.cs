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
        //A triangle is a figure when the sum of two sides is greater than the third side
        [TestCase(10, 10, 10)]
        [TestCase(20, 10, 20)]
        [TestCase(40, 20, 40)]
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

        //Isosceles Triangle has two sides equal an should still satisfy the is Triangle condition
        [TestCase(15, 15, 20)]
        [TestCase(35, 20, 20)]
        [TestCase(15, 25, 15)]
        public void Is_Isosceles_Triangle(int a, int b, int c)
        {
            string isIsoscelestriangle = FindTriangle.IsoscelesTriangle(a, b, c);
            Assert.AreEqual("It is an Isosceles triangle", isIsoscelestriangle);
            Console.WriteLine(isIsoscelestriangle);
        }
        
        [TestCase(15, 17, 20)]//scalene triangle values
        [TestCase(25, 25, 25)]//equilateral triangle values
        [TestCase(15, 15, 15)]
        public void Is_Not_Isosceles_Triangle(int a, int b, int c)
        {
            string isNotIsoscelestriangle = FindTriangle.IsoscelesTriangle(a, b, c);
            Assert.AreEqual("It is not an Isosceles triangle", isNotIsoscelestriangle);
            Console.WriteLine(isNotIsoscelestriangle);
        }
        //Scalene triangle is when all three sides are not equal and should still satisfy the is triangle condition
        [TestCase(15, 17, 20)]
        public void Is_Scalene_Triangle(int l, int m, int n)
        {
            string isScaleneTriangle = FindTriangle.ScaleneTriangle(l, m, n);
            Assert.AreEqual("It is a Scalene triangle", isScaleneTriangle);
            Console.WriteLine(isScaleneTriangle);

        }

        [TestCase(10, 10, 10)]//equilateral
        [TestCase(15, 25, 15)]//isosceles
        public void Is_Not_Scalene_Triangle(int l, int m, int n)
        {
            string isNotScaleneTriangle = FindTriangle.ScaleneTriangle(l, m, n);
            Assert.AreEqual("It is not a Scalene triangle", isNotScaleneTriangle);
            Console.WriteLine(isNotScaleneTriangle);

        }

        //Equilateral triangle is when all three sides are equal 
        [TestCase(50, 50, 50)]
        public void Is_Equilateral_Triangle(int o, int p, int q)
        {
            string isEquilateralTriangle = FindTriangle.EquilateralTriangle(o, p, q);
            Assert.AreEqual("It is an equilateral triangle", isEquilateralTriangle);
            Console.WriteLine(isEquilateralTriangle);
        }

        [TestCase(15, 25, 15)]//isosceles
        [TestCase(15, 17, 20)]//scalene
        public void Is_Not_Equilateral_Triangle(int o, int p, int q)
        {
            string isNotEquilateralTriangle = FindTriangle.EquilateralTriangle(o, p, q);
            Assert.AreEqual("It is not an equilateral triangle", isNotEquilateralTriangle);
            Console.WriteLine(isNotEquilateralTriangle);
        }
    }
}
