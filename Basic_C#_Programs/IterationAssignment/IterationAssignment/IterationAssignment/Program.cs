using System;
using System.Collections.Generic;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 94, 91, 98, 94 };

            //for (int i=0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] >85)
            //    {
            //        Console.WriteLine("Passing test score:" + testScores[i]);
            //    }
            //        Console.ReadLine();
            //}

            //string[] names = { "Brielle", "Kendra", "Natalie", "Jennifer" };

            //for (int j=0; j < names.Length; j++ )
            //{
            //    if(names[j] == "Brielle")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //        Console.ReadLine();
            //}

            //List<int> testScore = new List<int>();
            //testScore.Add(98);
            //testScore.Add(99);
            //testScore.Add(91);
            //testScore.Add(94);
            //testScore.Add(82);
            //testScore.Add(74);

            //foreach (int score in testScore)
            //{
            //    if(score > 96)
            //    {
            //        Console.WriteLine("Passing test score:" + score);
            //    }
            //    Console.ReadLine();
            //}

            string[] flavors = { "apple", "mango", "lime", "blueberry" };
            Console.WriteLine("Please enter the word that describes your favorite dessert:");
            string dessert = Console.ReadLine();

            for (int m = 0; m < flavors.Length; m++)
            {
                Console.WriteLine(flavors[m] + dessert);
            }
            Console.ReadLine();

            int[] numArray = { 2, 4, 6, 8 };

            for (int b = 0; b < numArray.Length; b++)
            {
                Console.WriteLine(numArray[b]);
            }
            Console.ReadLine();
        }

    } 
}
