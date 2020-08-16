using System;
using System.Collections.Generic;

namespace Algoholic.Sorts
{
    public abstract class BaseSort
    {
        public virtual IEnumerable<int> Sort(IEnumerable<int> collection)
        {
            throw new NotImplementedException();
        }
    }
}
