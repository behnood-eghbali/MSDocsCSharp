using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKeyword
{
    abstract class BaseClass   // Abstract class
    {
        protected int _x = 100;
        protected int _y = 150;
        public abstract void AbstractMethod();   // Abstract method
        public abstract int X { get; }
        public abstract int Y { get; }
    }
}
