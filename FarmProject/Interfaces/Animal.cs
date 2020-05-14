using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks
{
    interface Animal
    {
        public void makeNoise();
        public void eat();
        public void gettingOlder(int daysPass);
        public void sleep();
        public string getName();
        public int getAge();
    }
}
