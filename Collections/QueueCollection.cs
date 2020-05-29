using MentoringTasks.Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.Collections
{
    class QueueCollection: ICollections
    {
        Queue<Double> QueueExample = new Queue<Double>();
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public void FillCollection(string collectionType = "")
        {
            sw.Start();

            Random random = new Random();
            for (int i = 0; i < 7000; i++)
            {
                QueueExample.Enqueue(random.NextDouble());
            }

            sw.Stop();
            Console.WriteLine("Time to fill queue collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
        public double FindFirstElement()
        {
            sw.Start();

            double value = QueueExample.Peek();

            sw.Stop();
            Console.WriteLine("Time to find value by position in queue collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            return value;
        }

        public void RemoveBeginningElement()
        {
            sw.Start();

            QueueExample.Dequeue();

            sw.Stop();
            Console.WriteLine("Time to remove element by position in queue collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
    }
}
