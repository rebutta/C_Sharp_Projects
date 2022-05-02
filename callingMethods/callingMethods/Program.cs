using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer integer = new Integer(); //creates a new object from the class Integer 

            Console.WriteLine("What number would you like to see the math operations performed on?");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Five plus " + userNumber + " equals " + integer.methodOne(userNumber)); //calls on first method inputing user int
            Console.ReadLine();

            Console.WriteLine("Five times " + userNumber + " equals " + integer.methodTwo(userNumber));
            Console.ReadLine();

            Console.WriteLine("Hundred and fifty minus " + userNumber + " equals " + integer.methodThree(userNumber));
            Console.ReadLine();

            Console.WriteLine("Thank you for your time!");
            Console.ReadLine();
        }
    }
}
