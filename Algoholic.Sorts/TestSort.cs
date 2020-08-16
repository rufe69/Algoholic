using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algoholic.Sorts
{
    public class TestSort:BaseSort
    {
        public override ICollection<int> Sort(ICollection<int> collection)
        {
            var orderedNumbers = from i in collection
                                 orderby i
                                 select i;

            return orderedNumbers.ToList();
        }
    }
}
