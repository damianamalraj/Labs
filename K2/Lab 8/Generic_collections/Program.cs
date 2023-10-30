using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_collections
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "John Doe", "Male", 30000);
            Employee employee2 = new Employee(1, "Laura Doe", "Female", 30000);
            Employee employee3 = new Employee(1, "Kevin Doe", "Male", 30000);
            Employee employee4 = new Employee(1, "Susanne Doe", "Female", 30000);
            Employee employee5 = new Employee(1, "Mark Doe", "Male", 30000);

            Stack<Employee> employeesStack = new Stack<Employee>();
            void pushAllEmployeesIntoAStack()
            {
                employeesStack.Push(employee1);
                employeesStack.Push(employee2);
                employeesStack.Push(employee3);
                employeesStack.Push(employee4);
                employeesStack.Push(employee5);
            }
            pushAllEmployeesIntoAStack();

            foreach (var item in employeesStack.Select((value, i) => (value, i)))
            {
                Console.WriteLine($"{item.value.Name} and now {(employeesStack.Count - 1) - item.i} objects left to go 😉");
            }

            while (employeesStack.Count > 0)
            {
                Console.WriteLine($"{employeesStack.Pop().Name} now {employeesStack.Count} is left to go 😬");
            }

            pushAllEmployeesIntoAStack();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{employeesStack.ElementAtOrDefault(i)?.Name} now {(employeesStack.Count - 1) - i} is left to go 😆");
            }

            if (employeesStack.Contains(employee3))
            {
                Console.WriteLine($"{employee3.Name} - {employee3.Gender} - {employee3.} is there");
            }

        }
    }
}