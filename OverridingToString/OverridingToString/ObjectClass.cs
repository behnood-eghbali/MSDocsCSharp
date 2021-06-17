using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingToString
{
    public class ObjectClass
    {
        private object value;

        public ObjectClass(object value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + value.ToString();
        }
    }
}
