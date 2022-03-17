using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StudentGradeCalculator
{
    internal class Grading
    {

        public string studentName { get; set; }
        public string studentSurname { get; set; }
        public string studentID { get; set; }
        public string finalGrade { get; set; }
        public double averageMark { get; set; }

        private string[] subjects { get; set; } = { "PROG6211", "CLDV6211", "DBAS6211", "SAND6211" };
        public double[] finalMarks { get; set; } = new double[4];

        FinalGrading finalGrading = new FinalGrading();


        public void GetData()
        {
            Write("Please enter your name >> ");
            studentName = Console.ReadLine();
            Write("Please enter your surname >> ");
            studentSurname = Console.ReadLine();
            Write("Please enter your student ID >> ");
            studentID = Console.ReadLine();


            for (int i = 0; i < finalMarks.Length; i++)
            {
                finalMarks[i] = GetDouble(string.Format("Enter final mark for {0} >> ", subjects[i]));
            }

            averageMark = CalculateAverage(finalMarks);

            finalGrade = finalGrading.GetGrade(averageMark);

        }

        public void DisplayData()
        {
            WriteLine("------------------------------");
            WriteLine("Student name:\t\t {0}", studentName);
            WriteLine("Student surname:\t {0}", studentSurname);
            WriteLine("Student ID:\t\t {0}", studentID);
            for (int i = 0; i < finalMarks.Length; i++)
            {
                WriteLine("Mark for {0}:\t {1}/100", subjects[i], finalMarks[i]);
            }
            WriteLine("Average mark:\t\t {0}", averageMark);
            WriteLine("Final grading:\t\t {0}", finalGrade);
            WriteLine("------------------------------");
        }

        private double CalculateAverage(double[] marks)
        {
            double sum = 0;
            foreach (double mark in marks)
            {
                sum += mark;
            }
            return sum / marks.Length;
        }

        private double GetDouble(string s)
        {
            double userOutput = 0;
            string userInput = "";
            do
            {
                Write(s);
                userInput = Console.ReadLine();
            } while (!double.TryParse(userInput, out userOutput));
            return userOutput;
        }

    }
}
