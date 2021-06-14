using System;

namespace BaseKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E = new Employee();
            E.GetInfo();
            Console.WriteLine();
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(1);
        }
    }
    /*
    Output:
    Name: John L. Malgraine
    SSN: 444-55-6666
    Employee ID: ABC567EFG
    */

    /*
    Output:
    in BaseClass()
    in BaseClass(int i)
    */
}
