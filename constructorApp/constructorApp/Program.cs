using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int example1 = 50;

            var example2 = 125;

            Console.WriteLine(example1 + example2);

            NewEmployee employee1 = new NewEmployee("Billy", "Bob");
            Console.ReadLine();
        }
    }
}
