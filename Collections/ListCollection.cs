using MentoringTasks.Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentoringTasks.Collections
{
    class ListCollection: ICollections
    {
        List<Double> ListExample = new List<Double>();
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public void FillCollection(string collectionType = "")
        {
            sw.Start();

            Random random = new Random();
            for (int i = 0; i < 7000; i++)
            {
                ListExample.Add(random.NextDouble());
            }
            sw.Stop();
            Console.WriteLine("Time to fill list collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }

        public double FindValueByPosition(int position)
        {
            sw.Start();

            double value = ListExample[position];

            Console.WriteLine("Time to find value by position in list collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            return value;
        }

        public void RemoveElementByPosition(int position)
        {
            sw.Start();

            ListExample.RemoveAt(position);

            sw.Stop();
            Console.WriteLine("Time to remove element by position in list collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
    }
}
