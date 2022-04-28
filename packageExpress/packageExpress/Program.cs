using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace packageExpress
{
    class Program
    {
        static void Main()
        {
            //greeting
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();


            //weight 
            Console.WriteLine("What is the weight of your package?"); //console.writeline displays question
            int boxWeight = Convert.ToInt32(Console.ReadLine()); //displays the complete string until the user presses the enter key
            if (boxWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else if (boxWeight <= 50)
            {
                Console.WriteLine("Package is an acceptable weight to be shipped via Package Express.");
            }
            Console.ReadLine();

            //width, height, and length
            Console.WriteLine("What is the width of your package?");
            int boxWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the height of your package?");
            int boxHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the length of your package?");
            int boxLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Calculating package size... one moment...");
            Console.ReadLine();
            int boxTotal = boxWidth + boxHeight + boxLength;
            if (boxTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            }
            else if (boxTotal <= 50)
            {
                Console.WriteLine("Package is an acceptable size to be shipped via Package Express.");
            }
            Console.ReadLine();

            //quote

            Console.WriteLine("Calculating shipping cost for package... one moment...");
            Console.ReadLine();
            int boxCost = ((boxWidth * boxHeight * boxLength) * boxWeight) / 100;
            Console.WriteLine("Quoted estimated price to ship your package is: $" + boxCost);
            Console.ReadLine();
            Console.WriteLine("Thank you for your business!");
            Console.ReadLine();

        }
    }
}
