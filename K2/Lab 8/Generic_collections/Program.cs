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
            Employee employee1 = new Employee(101, "John Doe", "Male", 30000);
            Employee employee2 = new Employee(102, "Laura Doe", "Female", 30000);
            Employee employee3 = new Employee(103, "Kevin Doe", "Male", 30000);
            Employee employee4 = new Employee(104, "Susanne Doe", "Female", 30000);
            Employee employee5 = new Employee(105, "Mark Doe", "Male", 30000);

            // Del 1
            Console.WriteLine("Del 1");
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
            foreach (var item in employeesStack)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Gender} - {item.Salary}");
                Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Retrive Using Pop Method");
            while (employeesStack.Count > 0)
            {
                Employee employee;
                void popEmployee()
                {
                    employee = employeesStack.Pop();
                };
                popEmployee();

                Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Gender} - {employee.Salary}");
                Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");
            }
            pushAllEmployeesIntoAStack();
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Retrive Using Peek Method");
            for (int i = 0; i < 2; i++)
            {
                Employee? employee = employeesStack.ElementAtOrDefault(i);
                Console.WriteLine($"{employee?.Id} - {employee?.Name} - {employee?.Gender} - {employee?.Salary}");
                Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");
            }
            Console.WriteLine("-----------------------------");

            if (employeesStack.Contains(employee3))
            {
                Console.WriteLine("employee3 is in Stack");
            }
            Console.WriteLine("-----------------------------");

            // Del 2
            Console.WriteLine("\n\nDel 2");
            List<Employee> employeesList = new List<Employee>();

            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            employeesList.Add(employee4);
            employeesList.Add(employee5);

            if (employeesList.Contains(employee2))
            {
                Console.WriteLine("employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine("employee2 object does not exist in the list");
            }

            Employee? foundEmployee;
            void findEmployee()
            {
                foundEmployee = employeesList.Find(employee => employee.Gender == "Male");
            };
            findEmployee();
            Console.WriteLine($"\nID = {foundEmployee?.Id}, Name = {foundEmployee?.Name}, Gender = {foundEmployee?.Gender}, Salary = {foundEmployee?.Salary}\n");

            List<Employee> foundAllEmployee;
            void findAllEmployee()
            {
                foundAllEmployee = employeesList.FindAll(employee => employee.Gender == "Male");
            };
            findAllEmployee();

            foreach (var item in foundAllEmployee)
            {
                Console.WriteLine($"ID = {item?.Id}, Name = {item?.Name}, Gender = {item?.Gender}, Salary = {item?.Salary}");
            }
        }
    }
}