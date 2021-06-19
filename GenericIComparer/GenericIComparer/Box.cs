using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericIComparer
{
    public class Box : IComparable<Box>
    {

        public Box(int h, int l, int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }
        public int Height { get; private set; }
        public int Length { get; private set; }
        public int Width { get; private set; }

        public int CompareTo(Box other)
        {
            // Compares Height, Length, and Width.
            if (this.Height.CompareTo(other.Height) != 0)
            {
                return this.Height.CompareTo(other.Height);
            }
            else if (this.Length.CompareTo(other.Length) != 0)
            {
                return this.Length.CompareTo(other.Length);
            }
            else if (this.Width.CompareTo(other.Width) != 0)
            {
                return this.Width.CompareTo(other.Width);
            }
            else
            {
                return 0;
            }
        }
    }
}
