﻿using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 1, 2, 3, 5, 8};

            //foreach (int i in myArray) { Console.WriteLine(i); }

            foreach (int i in myArray) 
            {
                //Console.WriteLine(i); 
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
