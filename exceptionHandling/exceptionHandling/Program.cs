using System;
using System.Collections.Generic;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Pick a number to divide the list by."); // first line asks user to pick a number (int)
                int numberOne = Convert.ToInt32(Console.ReadLine()); // converts user entered string to int

                List<int> numbers = new List<int>() { 100, 50, 500, 70, 10, 7000, };

                Console.WriteLine("You are dividing the list by: " + numberOne);
                foreach (int number in numbers)
                {
                    Console.WriteLine(number / numberOne);
                }
                Console.ReadLine();
            }
            catch (FormatException ex) // catch for non int entry
            {
                Console.WriteLine("Please type a whole number."); // message displayed for FormatException
                return;
            }
            catch (DivideByZeroException ex) // catch for dividing by zero
            {
                Console.WriteLine("Please don't divide by zero."); // message displayed for DivideByZeroException
            }
            catch (Exception ex) // catch for any error not explicitly written above
            {
                Console.WriteLine(ex.Message); // message displayed for General Exception
            }
            finally 
            {
                Console.WriteLine("Thank you for your input! You may now leave the console, Goodbye.");
                Console.ReadLine(); //readline to allow user to read error without console ending abruptly 
            }

            
        }
    }
}
