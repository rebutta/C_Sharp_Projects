using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.Id = 555;
            employee2.Id = 555;

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
