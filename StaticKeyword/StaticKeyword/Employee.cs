using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
    public class Employee
    {
        public string id;
        public string name;

        public Employee()
        {
        }

        public Employee(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
    }
}
