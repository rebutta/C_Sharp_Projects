using System;


namespace dailyReport
{
    class Program
    {
        static void Main()
        {
            string greeting = "The Tech Academy \nStudent Daily Report."; //creating string for greeting to daily report
            Console.WriteLine(greeting); //console.writeline displaying the string made above
            string answer1 = Console.ReadLine(); //displays the complete string until the user presses the enter key

            Console.WriteLine("What is your name?"); //console.writeline displays next question
            string answer2 = Console.ReadLine(); //displays the complete string until the user presses the enter key

            Console.WriteLine("What course are you on?"); //console.writeline displays next question
            string answer3 = Console.ReadLine(); //displays the complete string until the user presses the enter key

            Console.WriteLine("What page number"); //console.writeline displays next question
            int answer4 = Convert.ToInt32(Console.ReadLine()); //displays the complete string until the user presses the enter key

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”"); //console.writeline displays next question
            bool answer5a = Convert.ToBoolean(Console.ReadLine()); //displays the complete string until the user presses the enter key

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics."); //console.writeline displays next question
            string answer6 = Console.ReadLine(); //displays the complete string until the user presses the enter key

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific."); //console.writeline displays next question
            string answer7 = Console.ReadLine(); //displays the complete string until the user presses the enter key

            Console.WriteLine("How many hours did you study today?"); //console.writeline displays next question
            int answer8 = Convert.ToInt32(Console.ReadLine()); //displays the complete string until the user presses the enter key

            string fairwell = "Thank you for your answers. An Instructor will respond to this shortly. \nHave a great day!"; //creating string for fairwell to daily report
            Console.WriteLine(fairwell); //console.writeline displaying the string made above
            Console.ReadLine(); //displays the complete string until the user presses the enter key
        }
    }
}


