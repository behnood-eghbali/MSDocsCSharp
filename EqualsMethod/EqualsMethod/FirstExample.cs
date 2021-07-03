using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsMethod.FirstExample
{
    class Point2D
    {
        protected int x, y;

        public Point2D() : this(0, 0)
        { }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Point2D p = (Point2D)obj;
                return (x == p.x) && (y == p.y);
            }
        }

        public override int GetHashCode()
        {
            return (x << 2) ^ y;
        }

        public override string ToString()
        {
            return String.Format("Point({0}, {1})", x, y);
        }
    }

    sealed class Point3D : Point2D
    {
        int z;

        public Point3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public override bool Equals(Object obj)
        {
            Point3D pt3 = obj as Point3D;
            if (pt3 == null)
                return false;
            else
                return base.Equals((Point2D)obj) && z == pt3.z;
        }

        public override int GetHashCode()
        {
            return (base.GetHashCode() << 2) ^ z;
        }

        public override String ToString()
        {
            return String.Format("Point({0}, {1}, {2})", x, y, z);
        }
    }
}
