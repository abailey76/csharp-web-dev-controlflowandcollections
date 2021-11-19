using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ourIntegers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            static int AddEven(List<int> list) 
            {
                int total = 0;
                foreach (int i in list)
                {
                    if (i % 2 == 0)
                    {
                        total += i;
                    }
                }
                return total;
            }
            Console.WriteLine(AddEven(ourIntegers));
        }
    }
}
