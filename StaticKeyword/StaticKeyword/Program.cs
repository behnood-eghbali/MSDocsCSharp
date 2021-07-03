using System;

namespace StaticKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the employee's ID: ");
            string id = Console.ReadLine();

            // Create and configure the employee object.
            Employee e = new Employee(name, id);
            Console.Write("Enter the current number of employees: ");
            string n = Console.ReadLine();
            Employee.employeeCounter = Int32.Parse(n);
            Employee.AddEmployee();

            // Display the new information.
            Console.WriteLine($"Name: {e.name}");
            Console.WriteLine($"ID:   {e.id}");
            Console.WriteLine($"New Number of Employees: {Employee.employeeCounter}");
        }
    }
    /*
    Input:
    Matthias Berndt
    AF643G
    15
     *
    Sample Output:
    Enter the employee's name: Matthias Berndt
    Enter the employee's ID: AF643G
    Enter the current number of employees: 15
    Name: Matthias Berndt
    ID:   AF643G
    New Number of Employees: 16
    */
}
