using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            // Create three employees
            Employee Merry = new Employee()
            {
                FisrtName = "Merry",
                LastName = "Brandybuck",
                Title = "Tree Herder",
                StartDate = new DateTime(1995, 05, 20)
            };
            Employee Pippin = new Employee()
            {
                FisrtName = "Pippin",
                LastName = "Took",
                Title = "Cook",
                StartDate = new DateTime(1995, 06, 20)
            };
            Employee Shagrat = new Employee()
            {
                FisrtName = "Shagrat",
                LastName = "The Orc",
                Title = "Murderer",
                StartDate = new DateTime(1996, 07, 30)
            };
            // Assign the employees to the company
            List<Employee> TreeBeardEmployees = new List<Employee>()
            {
                Merry, Pippin, Shagrat
            };

            Company myCompany = new Company("TreeBeards Lawn Care", new DateTime(1995, 5, 15), TreeBeardEmployees);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
