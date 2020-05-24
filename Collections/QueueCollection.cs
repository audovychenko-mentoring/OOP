using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.Collections
{
    class QueueCollection
    {
        Queue<Double> QueueExample = new Queue<Double>();
        public void FillCollection()
        {            
            for (int i = 0; i < 7000; i++)
            {
                Random random = new Random();
                QueueExample.Enqueue(random.NextDouble());
            }
        }
        public void FindAndPrintFirstElement()
        {
            Console.WriteLine(QueueExample.Peek());
        }

        public void RemoveBeginningElement()
        {
            QueueExample.Dequeue();
        }
    }
}
