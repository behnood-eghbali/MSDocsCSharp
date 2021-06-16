using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceConstructor
{
    class Coords
    {
        public int x, y;

        // Default constructor.
        public Coords()
        {
            x = 0;
            y = 0;
        }

        // A constructor with two arguments.
        public Coords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Override the ToString method.
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}
