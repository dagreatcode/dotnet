using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        static List<Employee> GetEmployees()
        {
            // We altered this declaration to handle Employee instances instead of strings.
            List<Employee> employees = new List<Employee>();
            // Collect user values until the value is an empty string
            while (true)
            {
                Console.WriteLine("Please enter a name: (leave empty to exit): ");
                string input = Console.ReadLine();
                // Break if the user hits ENTER without typing a name
                if (input == "")
                {
                    break;
                }
                // Create a new Employee instance
                Employee currentEmployee = new Employee(input, "Smith");
                // Add currentEmployee, not a string
                employees.Add(currentEmployee);
            }
            // This is important!
            return employees;
        }
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                // each item in employees is now an Employee instance
                Console.WriteLine(employees[i].GetName());
            }
        }
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}
