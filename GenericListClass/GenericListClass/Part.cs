using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListClass
{
    // Simple business object. A PartId is used to identify the type of part
    // but the part name can change.
    public class Part : IEquatable<Part>
    {
        public string PartName { get; set; }

        public int PartId { get; set; }

        public override string ToString()
        {
            return "ID: " + PartId + "   Name: " + PartName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Part objAsPart = obj as Part;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return PartId;
        }
        public bool Equals(Part other)
        {
            if (other == null) return false;
            return (this.PartId.Equals(other.PartId));
        }
        // Should also override == and != operators.
        public static bool operator ==(Part x, Part y)
        {
            if (x is null)
            {
                if (y is null)
                {
                    // null == null = true.
                    return true;
                }
                // Only x is null.
                return false;
            }
            // Equals handles the case of null on y.
            return x.Equals(y);
        }

        public static bool operator !=(Part x, Part y)
        {
            return !(x == y);
        }
    }
}
