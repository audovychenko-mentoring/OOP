using MentoringTasks.Farm.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MentoringTasks.Farm.FarmMembers
{
    class Cow: Animal, Cattle
    {
        private int lifeLength = 400;
        private String sound = "Mooo";
        private String[] food = { "grass", "corn", "grain" };
        public int age = 0;
        private String name;
        public int milkProduced = 0;

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

        public int givingMilk(int daysPass)
        {
            milkProduced += daysPass * 5;
            return daysPass*5;
        }

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
    }
}
