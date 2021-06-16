using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMembers
{
    public class DerivedClass : BaseClass
    {
        public new void DoWork()
        {
            Console.WriteLine("DerivedClass");
        }
        public new int WorkProperty
        {
            get { return 0; }
        }
    }
}
