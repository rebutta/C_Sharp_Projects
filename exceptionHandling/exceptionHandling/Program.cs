using System;

namespace exceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Pick a number."); // first line asks user to pick a number (int)
                int numberOne = Convert.ToInt32(Console.ReadLine()); // converts user entered string to int
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two...");
                int numberThree = numberOne / numberTwo; // dividing user entered int numberOne and numberTwo
                Console.WriteLine(numberOne + "divided by " + numberTwo + "equals " + numberThree); // displaying the above math
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
                Console.ReadLine(); //readline to allow user to read error without console ending abruptly 
            }
        }
    }
}
