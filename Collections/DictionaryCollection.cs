using StatsdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace MentoringTasks.Collections
{
    class DictionaryCollection : AbstractKeyValueCollections
    {
        Dictionary<int, string> DictionaryExample = new Dictionary<int, string>();

        public override IDictionary<int, string> GetCollection()
        {
            return DictionaryExample;
        }
    }
}
