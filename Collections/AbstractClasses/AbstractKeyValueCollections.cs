using MentoringTasks.Collections.Interfaces;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MentoringTasks.Collections
{
    abstract class AbstractKeyValueCollections: ICollections
    {
        System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
        public void FillCollection(string collectionType)
        {           

            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;

            sw.Start();

            for (int i = 0; i < 7000; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                GetCollection().Add(i, str_build.ToString());
            }
            sw.Stop();
            Console.WriteLine($"Time to fill {collectionType} collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }
        public string FindValueByKey(int key, string collectionType)
        {
            sw.Start();

            GetCollection().TryGetValue(key, out string value);

            sw.Stop();
            Console.WriteLine($"Time to find value by key in {collectionType} collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            return value;
        }
        public void RemoveElementByKey(int key, string collectionType)
        {
            sw.Start();

            GetCollection().Remove(key);

            sw.Stop();
            Console.WriteLine($"Time to remove element by key in {collectionType} collection with 7000 elements");
            Console.WriteLine("Elapsed={0}", sw.Elapsed);
        }

        public abstract IDictionary<int, string> GetCollection();
    }
}
