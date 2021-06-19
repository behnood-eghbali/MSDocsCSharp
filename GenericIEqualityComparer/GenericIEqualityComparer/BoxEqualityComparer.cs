using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIEqualityComparer
{
    class BoxEqualityComparer : IEqualityComparer<Box>
    {
        public bool Equals(Box b1, Box b2)
        {
            if (b2 == null && b1 == null)
                return true;
            else if (b1 == null || b2 == null)
                return false;
            else if (b1.Height == b2.Height && b1.Length == b2.Length
                                && b1.Width == b2.Width)
                return true;
            else
                return false;
        }

        public int GetHashCode(Box bx)
        {
            int hCode = bx.Height ^ bx.Length ^ bx.Width;
            return hCode.GetHashCode();
        }
    }
    // The example displays the following output:
    //    Unable to add (4, 3, 4): An item with the same key has already been added.
    //
    //    The dictionary contains 2 Box objects.
}
