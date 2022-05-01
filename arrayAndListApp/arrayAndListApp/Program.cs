using System;
using System.Collections.Generic;

namespace arrayAndListApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello. Welcome to the best database ever! \nJust kidding this is pretty sub-par...");
            Console.ReadLine();


            //STRING ARRAY
            string[] stringArray = { "This one", "That one", "Which one", "uhhhh one?" };

            Console.WriteLine("Pick a number from 0 and 3!");
            int userPick1 = Convert.ToInt32(Console.ReadLine());
            if (userPick1 > 3)
            {
                Console.WriteLine("There is not an index with that number. Next!");
            }
            else if (userPick1 <= 3)
            {
                Console.WriteLine("You picked: " + stringArray[userPick1]); 
            }
            Console.ReadLine();


            //INT ARRAY
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


            //STRING LIST
            List<string> aList = new List<string>();
            aList.Add("Hello again");
            aList.Add("Fidget spinners are cool");
            aList.Add("Nike started in Oregon");
            aList.Add("Pretend there is something interesting thing");

            Console.WriteLine("Pick a number from 0 and 3!");
            int userPick3 = Convert.ToInt32(Console.ReadLine());
            if (userPick3 > 3)
            {
                Console.WriteLine("There is not an index with that number. Next!");
            }
            else if (userPick3 <= 3)
            {
                Console.WriteLine("You picked: " + aList[userPick3]);
            }
            Console.ReadLine();
        }
    }
}
