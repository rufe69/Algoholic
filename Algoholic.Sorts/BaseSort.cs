using System;
using System.Collections.Generic;

namespace Algoholic.Sorts
{
    public abstract class BaseSort
    {
        public virtual IEnumerable<IComparable> Sort(IEnumerable<IComparable> collections)
        {
            throw new NotImplementedException();
        }
    }
}
