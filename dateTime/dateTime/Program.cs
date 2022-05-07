using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.ReadLine();

            Console.WriteLine("Please provide a number.");
            double userInput = Convert.ToInt32(Console.ReadLine());             

            Console.WriteLine("It will be: " + DateTime.Now.AddHours(userInput));
            Console.ReadLine();
        }
    }
}
