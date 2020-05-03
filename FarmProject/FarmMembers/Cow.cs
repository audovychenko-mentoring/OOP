using MentoringTasks.Farm.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MentoringTasks.Farm.FarmMembers
{
    class Cow: Animal, Cattle
    {
        int lifeLength = 4000;
        String sound = "Mooo";
        String[] food = { "grass", "corn", "grain" };
        int age = 0;
        String name;

        public Cow(string name)
        {
            this.name = name;
        }

        public void eat()
        {
            Console.WriteLine("Eating grass");
        }

        public string getName()
        {
            return name;
        }

        public int gettingOlder(int daysPass)
        {
            age += daysPass;
            return lifeLength - age;
        }

        public void givingMilk()
        {
            throw new NotImplementedException();
        }

        public void makeNoise()
        {
            Console.WriteLine(sound);
        }

        public void sleep()
        {
            Console.WriteLine("Zzzzz");
        }
    }
}
