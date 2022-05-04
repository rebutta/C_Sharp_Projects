using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee) //true or false answer so it is a bool, comparing two employee objects based on Id
        {
            bool equalTrue = false; //bool is set to false
            if (employee.Id == employee1.Id) //if employee Id matches they are the equal
            {
                equalTrue = true;
            }
            return equalTrue;
        }
        public static bool operator !=(Employee employee1, Employee employee)
        {
            bool equalFalse = false;
            if (employee.Id != employee1.Id)
            {
                equalFalse = true;
            }
            return equalFalse;
        }

    }
}
