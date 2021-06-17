using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingToString
{
    public class CList<T> : List<T>
    {
        public CList(IEnumerable<T> collection) : base(collection)
        { }

        public CList() : base()
        { }

        public override string ToString()
        {
            string retVal = string.Empty;
            foreach (T item in this)
            {
                if (string.IsNullOrEmpty(retVal))
                    retVal += item.ToString();
                else
                    retVal += string.Format(", {0}", item);
            }
            return retVal;
        }
    }
}
