﻿using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "I would not, could not, in a box. I would not, could not with a fox. " +
                "I will not eat them in a house. I will not eat them with a mouse. ";

            string[] myArray = myStr.Split(' ');

            Console.WriteLine(string.Join(" ", myArray));

            string[] myOtherArray = myStr.Split(". ");

            foreach (string str in myOtherArray)
            {
                Console.WriteLine(str);
            } ;
        }
    }
}
