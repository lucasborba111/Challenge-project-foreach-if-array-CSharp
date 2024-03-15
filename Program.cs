using System;

namespace PraticandoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

            int[] studentScores = new int[10];
            string currentStudentLetterGrade;

            string[] studentsNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit");

            foreach (string name in studentsNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;
                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;
                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                int sumAssignmentScores = 0;

                decimal currentStudentGrade = 0;

                int gradedAssignments = 0;

                decimal sumGraded = 0;
                decimal sumGradedScore = 0;
                decimal overAll = 0;
                decimal sumExtraCredit = 0;
                decimal currentStudentExtraCreditScore = 0;
                decimal gradedExtraCreditAssignments = 0;

                foreach (int score in studentScores)
                {
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)
                        sumAssignmentScores += score;
                    else
                    {
                        gradedExtraCreditAssignments += 1;
                        sumGraded += (decimal)score / 10;
                        sumGradedScore += score;
                    }
                }

                currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

                overAll = (sumAssignmentScores + sumGraded) / examAssignments;

                sumExtraCredit = (sumGradedScore * 0.1m) / 5;

                currentStudentExtraCreditScore = (sumGradedScore) / gradedExtraCreditAssignments;

                if (overAll >= 97)
                    currentStudentLetterGrade = "A+";

                else if (overAll >= 93)
                    currentStudentLetterGrade = "A";

                else if (overAll >= 90)
                    currentStudentLetterGrade = "A-";

                else if (overAll >= 87)
                    currentStudentLetterGrade = "B+";

                else if (overAll >= 83)
                    currentStudentLetterGrade = "B";

                else if (overAll >= 80)
                    currentStudentLetterGrade = "B-";

                else if (overAll >= 77)
                    currentStudentLetterGrade = "C+";

                else if (overAll >= 73)
                    currentStudentLetterGrade = "C";

                else if (overAll >= 70)
                    currentStudentLetterGrade = "C-";

                else if (overAll >= 67)
                    currentStudentLetterGrade = "D+";

                else if (overAll >= 63)
                    currentStudentLetterGrade = "D";

                else if (overAll >= 60)
                    currentStudentLetterGrade = "D-";
                else
                    currentStudentLetterGrade = "F";

                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t" + overAll + $"\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore}({sumExtraCredit} pts)");
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }
    }
}
