using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractKeyword
{
    class DerivedClass : BaseClass
    {
        public override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        public override int X   // overriding property
        {
            get
            {
                return _x + 10;
            }
        }

        public override int Y   // overriding property
        {
            get
            {
                return _y + 10;
            }
        }
    }
}
