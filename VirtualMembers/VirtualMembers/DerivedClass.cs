using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMembers
{
    public class DerivedClass : BaseClass
    {
        public override void DoWork()
        {
            Console.WriteLine("DerivedClass");
        }
        public override int WorkProperty
        {
            get { return 0; }
        }
    }
}
