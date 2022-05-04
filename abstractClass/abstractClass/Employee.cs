using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractClass
{
    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            base.SayName();
        }
    }
}
