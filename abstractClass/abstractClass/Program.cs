using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            Console.ReadLine();


            // Polymorphism Submission
            IQuittable quit = new Employee();
            quit.Quit(employee);
            Console.ReadLine();
        }
    }
}
