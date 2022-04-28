using System;


namespace BooleanInsurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Boolean Car Insurance! \nYou will be asked a few questions to determine if you qualify.");
            Console.ReadLine();

            Console.WriteLine("What is your age?"); //console.writeline displays question
            int age = Convert.ToInt32(Console.ReadLine()); //displays the complete string until the user presses the enter key

            Console.WriteLine("Have you ever had a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.Write("Did you qualify?");
            Console.ReadLine();

            bool GoodOrBadDriver = (age > 15 && dui == false && tickets < 4);
            Console.WriteLine(GoodOrBadDriver);
            Console.ReadLine();
        }
    }
}


////What is your age ?
//32
////Have you ever had a DUI?
//false
////How many speeding tickets do you have?
//1
////Qualified?
//true