using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    class Counter
    {
        private Counter() { }

        public static int currentCount;

        public static int IncrementCount()
        {
            return ++currentCount;
        }
    }
}
