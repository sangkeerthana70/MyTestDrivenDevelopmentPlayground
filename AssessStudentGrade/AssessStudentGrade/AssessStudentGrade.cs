using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessStudentGrade
{
    class AssessStudentGrade
    {
        //property
        public int scoreOfStudent { get; set; }
        //empty constructor
        public  AssessStudentGrade()
        {

        }
        //methods
        public string CalcGrade(int score)
        {
            string grade = "";
            if ( score > 97)
            {
                grade = "A+";
                
            }
            if ((score >= 92) && (score <= 97))
            {
                grade = "A";
            }
            if ((score >= 85) && (score <= 91))
            {
                grade = "B";
            }
            if ((score >=75) && (score <= 84))
            {
                grade = "C";
            }
            else
            {
                grade = "D";
            }
            return grade;
        }
    }
}
