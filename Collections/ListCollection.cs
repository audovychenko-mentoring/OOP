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
            for (int i = 0; i < 7000; i++)
            {
                Random random = new Random();
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
