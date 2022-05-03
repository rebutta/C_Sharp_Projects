using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // main method submission 
            Integer integer = new Integer(); //creates a new object from the class Integer

            Console.WriteLine(integer.methodOne(10));
            Console.ReadLine();

            Console.WriteLine(integer.methodOne(20.00));
            Console.ReadLine();

            Console.WriteLine(integer.methodOne("8"));
            Console.ReadLine();

            // method submission 

            Integer2 integer2 = new Integer2();
            Console.WriteLine("Please choose the first of one to two numbers to use in my method.");
            int pickA = Convert.ToInt32(Console.ReadLine());
            try
            {               
                Console.WriteLine("NOT required but you can choose the second of two numbers to use in my method.");
                int pickB = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(integer2.methodUno(pickA, pickB));
            }
            catch (FormatException ex)
            {
                Console.WriteLine(integer2.methodUno(pickA));
            }
            finally
            {
                Console.ReadLine();
            }
        }   
    }
}