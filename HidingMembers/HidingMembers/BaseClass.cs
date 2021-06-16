using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMembers
{
    public class BaseClass
    {
        public void DoWork()
        {
            Console.WriteLine("BaseClass");
        }
        public int WorkProperty
        {
            get { return 0; }
        }
    }
}
