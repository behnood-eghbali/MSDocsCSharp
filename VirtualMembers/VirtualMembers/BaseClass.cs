using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMembers
{
    public class BaseClass
    {
        public virtual void DoWork()
        {
            Console.WriteLine("BaseClass");
        }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }
}
