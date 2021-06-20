using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericEqualityComparer
{
    class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals(Box b1, Box b2)
        {
            if (b1 == null && b2 == null)
                return true;
            else if (b1 == null || b2 == null)
                return false;

            return (b1.Height * b1.Width * b1.Length ==
                    b2.Height * b2.Width * b2.Length);
        }

        public override int GetHashCode(Box bx)
        {
            int hCode = bx.Height * bx.Length * bx.Width;
            return hCode.GetHashCode();
        }
    }
}
