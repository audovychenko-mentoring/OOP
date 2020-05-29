using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentoringTasks.Collections
{
    class SortedListCollection: AbstractKeyValueCollections
    {
        SortedList<int, string> SortedListExample = new SortedList<int, string>();

        public override IDictionary<int, string> GetCollection()
        {
            return SortedListExample;
        }
    }
}
