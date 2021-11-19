using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> students = new Dictionary<int, double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student ID No: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Grade: ");
                    input = Console.ReadLine();
                    double newGrade = double.Parse(input);
                    students.Add(int.Parse(newStudent), newGrade);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<int, double> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
                sum += student.Value;
            }

            double avg = sum / students.Count;
            Console.WriteLine("Average grade: " + avg);
        }
    }
}
