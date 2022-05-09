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
        public NewEmployee(): this("sample", "employee")
        {           
        }
        public NewEmployee(string firstName, string lastName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the employee, with first name: {0} and last name: {1}", firstName, lastName); //created a constructor with two parameters
        }

    }
}
