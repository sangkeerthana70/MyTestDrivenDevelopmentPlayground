﻿using System;
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

        public static string isIsoscelesTriangle(int a, int b, int c)
        {
            return "";
        }



    }
}