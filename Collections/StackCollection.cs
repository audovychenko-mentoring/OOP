using MentoringTasks.Collections.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.Collections
{
    class StackCollection: ICollections
    {
        Stack<Double> StackExample = new Stack<Double>();
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public void FillCollection(string collectionType = "")
        {
            sw.Start();

            Random random = new Random();
            for (int i = 0; i < 7000; i++)
            {                
                StackExample.Push(random.NextDouble());
            }

            sw.Stop();
            Console.WriteLine("Time to fill stack collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
        public double FindTopElement()
        {
            sw.Start();

            double value = StackExample.Peek();

            sw.Stop();
            Console.WriteLine("Time to find top element in stack collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            return value;
        }
        public void RemoveTopElement()
        {
            sw.Start();

            StackExample.Pop();

            sw.Stop();
            Console.WriteLine("Time to remove top element in stack collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
    }
}
