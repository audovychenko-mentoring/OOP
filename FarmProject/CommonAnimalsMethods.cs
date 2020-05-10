using MentoringTasks.Farm.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.FarmProject
{
    abstract class CommonAnimalsMethods : Animal
    {
        protected int lifeLength;
        protected String sound;
        protected String[] food;
        protected int age;
        protected String name;

        public void eat()
        {
            Console.WriteLine("Om nom nom");
        }

        public int gettingOlder(int daysPass)
        {
            age += daysPass;
            return lifeLength - age;
        }

        public abstract int givingProduce(int daysPast);

        public void makeNoise()
        {
            Console.WriteLine(sound);
        }

        public void sleep()
        {
            Console.WriteLine("Zzzzz");
        }

        public int getAge()
        {
            return age;
        }

        public string getName()
        {
            return name;
        }
    }
}
