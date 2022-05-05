using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambdaConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Dirt";
            employee1.Id = 01;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.FirstName = "Joe";
            employee2.LastName = "Smith";
            employee2.Id = 02;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Michael";
            employee3.LastName = "Beckham";
            employee3.Id = 03;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Austin";
            employee4.LastName = "Sandler";
            employee4.Id = 04;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "Christopher";
            employee5.LastName = "Hayes";
            employee5.Id = 05;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Jeffery";
            employee6.LastName = "Jackson";
            employee6.Id = 06;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "James";
            employee7.LastName = "Stark";
            employee7.Id = 07;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "Rachel";
            employee8.LastName = "Thomas";
            employee8.Id = 08;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Aspen";
            employee9.LastName = "Arth";
            employee9.Id = 09;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.FirstName = "Sarah";
            employee10.LastName = "Wilbur";
            employee10.Id = 10;
            employees.Add(employee10);

            List<Employee> employeesList = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {                   
                    employeesList.Add(employee);
                }
            }

            List<Employee> lambdaList = employees.Where(x => x.FirstName == "Joe").ToList();

            List<Employee> lambdaList1 = employees.Where(x => x.Id > 5).ToList();

        }
    }
}
