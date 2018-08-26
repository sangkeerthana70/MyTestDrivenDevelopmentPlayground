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
            if ( score >= 97)
            {
                grade = "A+";
                
            }
            if ((score >= 92) && (score <= 97))
            {
                grade = "A";
            }
            return grade;
        }
    }
}
