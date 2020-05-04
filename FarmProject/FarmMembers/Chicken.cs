using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.Farm.FarmMembers
{
    class Chicken:Animal, Bird
    {
        private int lifeLength = 150;
        private String sound = "Co Co Co";
        private String[] food = { "mash", "crumble", "pellets" };
        public int age = 0;
        private String name;
        public int eggsProduced = 0;

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

        public int produceEggs(int daysPass)
        {
            eggsProduced += daysPass * 3;
            return daysPass * 5;
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

        public int getAge()
        {
            return age;
        }
    }
}
