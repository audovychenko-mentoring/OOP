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
            for (int i = 0; i < 7000; i++)
            {
                Random random = new Random();
                StackExample.Push(random.NextDouble());
            }
            Console.WriteLine(StackExample);
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
