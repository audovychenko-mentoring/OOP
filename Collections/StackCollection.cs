using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.Collections
{
    class StackCollection
    {
        Stack<Double> StackExample = new Stack<Double>();
        public void FillCollection()
        {
            Random random = new Random();
            for (int i = 0; i < 7000; i++)
            {                
                StackExample.Push(random.NextDouble());
            }
        }
        public void FindAndPrintTopElement()
        {
            Console.WriteLine(StackExample.Peek());
        }
        public void RemoveTopElement()
        {
            StackExample.Pop();
        }
    }
}
