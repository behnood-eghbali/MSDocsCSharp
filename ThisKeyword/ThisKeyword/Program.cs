using System;

namespace ThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects:
            Employee E1 = new Employee("Mingda Pan", "mpan");

            // Display results:
            E1.printEmployee();
        }
    }
    /*
    Output:
        Name: Mingda Pan
        Alias: mpan
        Taxes: $240.00
    */
}
