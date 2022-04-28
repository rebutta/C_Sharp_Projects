using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //console.writeline name of program
            Console.ReadLine(); //displays the complete string until the user presses the enter key

            //Person 1

            Console.WriteLine("Person 1"); //console.writeline name first user
            Console.ReadLine(); 

            Console.WriteLine("What is your hourly rate?"); //console.writeline displays question
            int person1Pay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours worked per week"); //console.writeline displays next question
            int person1Hours = Convert.ToInt32(Console.ReadLine()); 

            //Person 2

            Console.WriteLine("Person 2");
            Console.ReadLine();

            Console.WriteLine("What is your hourly rate?");
            int person2Pay = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("How many hours worked per week"); 
            int person2Hours = Convert.ToInt32(Console.ReadLine());

            //Adding annual salary of both persons

            int person1WeekTotal = person1Hours * person1Pay; //one week of pay

            int person2WeekTotal = person2Hours * person2Pay; 

            int person1Annual = person1WeekTotal * 52; //multiply by weeks in a year (52 weeks)

            int person2Annual = person2WeekTotal * 52; 

            Console.WriteLine("Annual salary of Person 1: $" + person1Annual); //displays person1 annual salary
            Console.ReadLine();

            Console.WriteLine("Annual salary of Person 2: $" + person2Annual); 
            Console.ReadLine();

            //Boolean comparing salaries

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool bigBaller = person1Annual > person2Annual;
            Console.WriteLine(bigBaller);
            Console.ReadLine();

        }
    }
}