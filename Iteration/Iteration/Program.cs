using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();



            //string[] names = { "Jesse", "Bob", "Daniel", "Adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //Console.ReadLine();



            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();



            //List<string> names = new List<string>() { "Jesse", "Bob", "Daniel", "Adam" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //Console.ReadLine();



            //List<int> testScores = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
            //Console.WriteLine(passingScores.Count);
            //Console.ReadLine();

            int[] intArray = { 3, 2, 1, 0 };

            Console.WriteLine("Pick a number from 0 and 3!");
            int userPick2 = Convert.ToInt32(Console.ReadLine());
            if (userPick2 > 3)
            {
                Console.WriteLine("There is not an index with that number. Next!");
            }
            else if (userPick2 <= 3)
            {
                Console.WriteLine("You picked the number: " + intArray[userPick2]);
            }
            Console.ReadLine();
        }
    }
}
