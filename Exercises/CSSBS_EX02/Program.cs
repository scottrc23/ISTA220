﻿using System;

namespace csex02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average ten numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.Write($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user predetermined number of scores.");
            Console.Write("How many scores do you wish to enter? ");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4, average non-predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of five integers is {avg2} and the letter grade is {letterGrade}");

        }

        private static char ConvertNumericToLetterGrade(double avg)
        {
            if (avg >= 90) return ('A');
            else if (avg >= 80) return ('B');
            else if (avg >= 70) return ('C');
            else if (avg >= 60) return ('D');
            else return 'F';
        }

        private static double AvgAnyInts(int sum, int count)
        {
            Console.Write("Please enter a score: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            sum += int.Parse(input);
            count++;
            if (value == -1)
                return sum / count;
            else
                return AvgAnyInts(sum, count);
        }

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            Console.WriteLine("Please enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < numScores)
                return AvgUnkInts(sum, count, numScores);
            else return (sum / (numScores));
        }


        private static double AvgTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return AvgTenInts(sum, count);
            else 
                return sum / count;

        }

        private static int SumTenInts(int sum, int count)
        {
            Console.Write("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            count++;
            if (count < 10)
                return SumTenInts(sum, count);
            else
                return sum;
        }
    }
}




