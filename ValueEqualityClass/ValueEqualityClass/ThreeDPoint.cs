using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueEqualityClass
{
    // For the sake of simplicity, assume a ThreeDPoint IS a TwoDPoint.
    class ThreeDPoint : TwoDPoint, IEquatable<ThreeDPoint>
    {
        public int Z { get; private set; }

        public ThreeDPoint(int x, int y, int z)
            : base(x, y)
        {
            if ((z < 1) || (z > 2000))
            {
                throw new ArgumentException("Point must be in range 1 - 2000");
            }
            this.Z = z;
        }

        public override bool Equals(object obj) => this.Equals(obj as ThreeDPoint);

        public bool Equals(ThreeDPoint p)
        {
            if (p is null)
            {
                return false;
            }

            // Optimization for a common success case.
            if (Object.ReferenceEquals(this, p))
            {
                return true;
            }

            // Check properties that this class declares.
            if (Z == p.Z)
            {
                // Let base class check its own fields
                // and do the run-time type comparison.
                return base.Equals((TwoDPoint)p);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode() => (X, Y, Z).GetHashCode();

        public static bool operator ==(ThreeDPoint lhs, ThreeDPoint rhs)
        {
            if (lhs is null)
            {
                if (rhs is null)
                {
                    // null == null = true.
                    return true;
                }

                // Only the left side is null.
                return false;
            }
            // Equals handles the case of null on right side.
            return lhs.Equals(rhs);
        }

        public static bool operator !=(ThreeDPoint lhs, ThreeDPoint rhs) => !(lhs == rhs);
    }
}
