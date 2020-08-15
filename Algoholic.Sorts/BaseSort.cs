using System;
using System.Collections.Generic;

namespace Algoholic.Sorts
{
    public abstract class BaseSort
    {
        public virtual ICollection<int> Sort(ICollection<int> collection)
        {
            throw new NotImplementedException();
        }
    }
}
