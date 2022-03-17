using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    internal class FinalGrading
    {
        public string GetGrade(double averageMark)
        {
            switch (averageMark)
            {
                case double n when n >= 75:
                    return "First Class";
                    break;
                case double n when n >= 65:
                    return "Second Class";
                    break;
                case double n when n >= 50:
                    return "Third Class";
                    break;
                default:
                    return "Fail";
                    break;
            }
        }
    }
}
