using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.Farm.FarmMembers
{
    class Chicken:Animal, Bird
    {
        int lifeLength = 150;
        String sound = "Co Co Co";
        String[] food = { "mash", "crumble", "pellets" };
        int age = 0;
        String name;

        public Chicken(String name)
        {
            this.name = name;
        }

        public void fly()
        {
            Console.WriteLine("Trying to escape");
        }

        public void eat()
        {
            Console.WriteLine("Om nom nom");
        }

        public void sleep()
        {
            Console.WriteLine("Zzzzzz");
        }

        public void makeNoise()
        {
            Console.WriteLine("Co co co");
        }

        public void produceEggs()
        {
            throw new NotImplementedException();
        }

        public int gettingOlder(int daysPass)
        {
            age += daysPass;
            return lifeLength - age;
        }

        public string getName()
        {
            return name;
        }
    }
}
