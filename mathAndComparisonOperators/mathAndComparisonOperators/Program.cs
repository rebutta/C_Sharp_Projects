using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine("Ten times Five = " + product.ToString());
            //Console.ReadLine();

            //int quotient = 100 / 5;
            //Console.WriteLine("Hundred divided Five = " + quotient.ToString());
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;
            //Console.WriteLine("Hundred divided Seventeen = " + quotient.ToString());
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();



            int roomTemp = 70;
            int currentTemp = 70;

            //bool isWarm = currentTemp >= roomTemp;
            bool isWarm = currentTemp != roomTemp;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
