using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    internal class AverageGrading
    {
        static void Main(string[] args)
        {
            Grading grading = new Grading();
            grading.GetData();
            grading.DisplayData();
            Console.ReadKey();
        }
    }
}
