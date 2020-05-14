using MentoringTasks.Farm.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.FarmProject
{
    abstract class AbstractAnimal : Animal
    {
        protected int lifeLength;
        protected String sound;
        protected String[] food;
        protected int age;
        protected String name;

        public void eat()
        {
            Random rand = new Random();
            int index = rand.Next(food.Length);
            Console.WriteLine(getName() + $"eating {food[index]} Om nom nom");
        }

        public void gettingOlder(int daysPass)
        {
            age += daysPass;
        }

        public abstract int givingProduce(int daysPast);

        public void makeNoise()
        {
            Console.WriteLine("I am " + getName() + "and I'm talking like" + sound);
        }

        public void sleep()
        {
            Console.WriteLine(getName() + " doing zzzzzz ");
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
