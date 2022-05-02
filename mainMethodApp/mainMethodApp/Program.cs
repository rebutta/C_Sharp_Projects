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
            Integer integer = new Integer(); //creates a new object from the class Integer

            Console.WriteLine(integer.methodOne + 10);
        }
    }
}
