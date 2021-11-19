using System;
using System.Collections.Generic;

namespace ListPracticeBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myStr = "I would not, could not, in a box. I would not, could not with a fox. " +
                "I will not eat them in a house. I will not eat them with a mouse. ".Replace(".","");

            List<string> myList = new List<string>(myStr.Split(' '));

            static void Write(List<string> list)
            {
                foreach (string item in list)
                {
                    if (item.Length == 5)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            Write(myList);
            //string[] myArray = myStr.Split(' ');

            //Console.WriteLine(string.Join(" ", myArray));

            //string[] myOtherArray = myStr.Split(". ");

            //foreach (string str in myOtherArray)
            //{
            //    Console.WriteLine(str);
            //} ;
        }
    }
}
