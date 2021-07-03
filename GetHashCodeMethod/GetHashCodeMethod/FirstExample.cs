using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCodeMethod.FirstExample
{
    // A type that represents a 2-D point.
    public struct Point2D
    {
        private int x;
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Point2D)) return false;

            Point2D p = (Point2D)obj;
            return x == p.x & y == p.y;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }
    }
}
