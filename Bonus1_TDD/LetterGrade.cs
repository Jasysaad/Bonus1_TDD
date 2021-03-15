using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus1_TDD
{
    public class LetterGrade
    {
        public int _grade { get; set; }
        public string letterGrade(double _grade)
        {
            double grade = _grade;
            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string f = "F";
            if (grade <= 100 && grade >= 90)
            {
                return a;
            }
            else if (grade < 90 && grade >= 80)
            {
                return b;
            }
            else if (grade < 80 && grade >= 70)
            {
                return c;
            }
            else if (grade < 70 && grade >= 60)
            {
                return d;
            }
            else
            {
                return f;
            }
        }
    }
}
