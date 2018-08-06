using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTriangleType
{
    class FindTriangle
    {


        public static string TriangleType(int a, int b, int c)
        {
            //string triangleType;
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                //triangleType =  "It is a triangle";
                return "It is a triangle";

            }
            else
            {
                return "It is not a triangle";
            }

        }

        public static string IsoscelesTriangle(int a, int b, int c)
        {
            if ((a == b && a != c) || (b == c && b != a) || (c == a && c != b))
            {
                return "It is an Isosceles triangle";
            }
            else
                return "It is not an Isosceles triangle";
            
        }

        public static string ScaleneTriangle(int l, int m, int n)
        {
            if (l != m && l != n && m != n)
            {
                return "It is a Scalene triangle";
            }
            else 
                return "It is not a Scalene triangle";
        }

        public static string EquilateralTriangle(int o, int p, int q)
        {
            return "";
        }


    }
}
