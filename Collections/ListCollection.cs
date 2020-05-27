using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentoringTasks.Collections
{
    class ListCollection
    {
        List<Double> ListExample = new List<Double>();
        public void FillCollection()
        {
            Random random = new Random();
            for (int i = 0; i < 7000; i++)
            {
                ListExample.Add(random.NextDouble());
            }
        }

        public void FindAndPrintValueByPosition(int position)
        {
            Console.WriteLine(ListExample[position]);
        }

        public void RemoveElementByPosition(int position)
        {
            ListExample.RemoveAt(position);
        }
    }
}
