using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorApp
{
    public class NewEmployee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public NewEmployee()
        {
            Console.WriteLine("Reserving new record for the employee."); //created a constructor with no parameters
        }
        public NewEmployee(string firstName)
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the employee, with first name!"); //created a constructor with one parameter
        }
        public NewEmployee(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the employee, with first name and last name!"); //created a constructor with two parameters
        }

    }
}
