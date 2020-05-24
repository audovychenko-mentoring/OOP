using StatsdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentoringTasks.Collections
{
    class DictionaryCollection
    {
        Dictionary<int, string> DictionaryExample = new Dictionary<int, string>();
        public void FillCollection()
        {
            for (int i = 0; i < 7000; i++)
            {
                StringBuilder str_build = new StringBuilder();
                Random random = new Random();

                char letter;

                for (int j = 0; j < 10; j++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);
                }
                DictionaryExample.Add(i, str_build.ToString());
            }
            Console.WriteLine(DictionaryExample);
        }
        public void FindAndPrintValueByKey(int key)
        {
            Console.WriteLine(DictionaryExample.FirstOrDefault(x => x.Key == key).Value);
        }
        public void RemoveElementByKey(int key)
        {
            DictionaryExample.Remove(key);
        }
    }
}
