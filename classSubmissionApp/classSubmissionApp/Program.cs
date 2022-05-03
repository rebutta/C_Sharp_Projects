using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classSubmissionApp
{
    class Program
    {
        static int intMethod(int a)
        {
            return a + 10;
        }
        static int intMethod(int a, int b, int c)
        {
            return (a + 10) * b / c;
        }
        static void Main(string[] args)
        {
            voidMethodClass voidMethodClass = new voidMethodClass();

            Console.WriteLine("Please enter a whole even number.");
            int userInput = Convert.ToInt32(Console.ReadLine());

            voidMethodClass.methodUno(userInput);
            Console.ReadLine();

            Console.WriteLine(intMethod(10));
            Console.ReadLine();



        }
    }
}
