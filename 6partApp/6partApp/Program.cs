using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6partApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Options = { "Dried ", "Smoked ", "Cured ", "Baked ", "Fried ", "Pickled " };

            //

            Console.WriteLine("Welcome to the C# Butcher Shop, what kind of meat would you like?");
            string customerMeat = Console.ReadLine();

            //

            Console.WriteLine("What kind?");
            for (int j = 0; j < Options.Length; j++)
            {
                Options[j] = Options[j] + customerMeat;
            }
            for (int j = 0; j < Options.Length; j++)
            {
                Console.WriteLine(Options[j]); 
            }
            Console.ReadLine();

            //
            //while (true)
            //{
                
            //}
            //

            Console.WriteLine("I recommend any with five letters!");
            for (int j = 0; j < Options.Length; j++)
            {
                Console.WriteLine(Options[j].Length <= 6);
            }
            Console.ReadLine();

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //

            List<string> butchersFav = new List<string>();
            butchersFav.Add("Dried ");
            butchersFav.Add("Fried ");
            butchersFav.Add("Cured ");
            butchersFav.Add("Baked ");

            Console.WriteLine("Which style would you like for your " + customerMeat);
            string customerStyle = Console.ReadLine();

            bool styleFound = false;
            for (int i = 0; i < butchersFav.Count; i++)
            {
                if (butchersFav[i] == customerStyle)
                {
                    Console.WriteLine("You chose style at index: " + i);
                    styleFound = true;
                    break;
                }
            }
            if (!styleFound) { Console.WriteLine("That is not a style we serve"); }
            Console.ReadLine();

            // 

            List<string> packaging = new List<string>();
            packaging.Add("Wrapped ");
            packaging.Add("Bagged ");
            packaging.Add("Wrapped ");
            packaging.Add("Wrapped and Bagged ");

            for (int i = 0; i < packaging.Count; i++)
            {
                if (packaging[i] == customerStyle)
                {
                    Console.WriteLine("You chose style at index: " + i);
                    styleFound = true;                    
                }
            }
            if (!styleFound) { Console.WriteLine("That is not a style we serve"); }
            Console.ReadLine();

            List<string> theList = new List<string>();

            foreach (string )

        }
    }
}
