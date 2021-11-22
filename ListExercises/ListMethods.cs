using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    internal static class ListMethods
    {
        public static int SumEvens(List<int> numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                } 
            }
            return sum;
        }
    }
}
