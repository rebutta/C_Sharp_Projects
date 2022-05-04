using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the day of the week.");
                string userAnswer = Console.ReadLine();

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userAnswer);
                if (day == DaysOfTheWeek.Monday)
                {
                    Console.WriteLine("It is Monday!");
                    Console.ReadLine();
                }
                if (day == DaysOfTheWeek.Tuesday)
                {
                    Console.WriteLine("It is Tuesday!");
                    Console.ReadLine();
                }
                if (day == DaysOfTheWeek.Wednesday)
                {
                    Console.WriteLine("It is Wednesday!");
                    Console.ReadLine();
                }
                if (day == DaysOfTheWeek.Thursday)
                {
                    Console.WriteLine("It is Thursday!");
                    Console.ReadLine();
                }
                if (day == DaysOfTheWeek.Friday)
                {
                    Console.WriteLine("It is Friday!");
                    Console.ReadLine();
                }
                if (day == DaysOfTheWeek.Saturday)
                {
                    Console.WriteLine("It is Saturday!");
                    Console.ReadLine();
                }
                if (day == DaysOfTheWeek.Sunday)
                {
                    Console.WriteLine("It is Sunday!");
                    Console.ReadLine();
                }
            }
            catch (ArgumentException ex) // catch for non string/enum entry
            {
                Console.WriteLine("Please enter an actual day of the week."); // message displayed for FormatException
                return;
            }
            finally
            {               
                Console.ReadLine(); //readline to allow user to read error without console ending abruptly 
            }

        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}
