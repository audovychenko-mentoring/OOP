
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks
{
    class AnimalsFarmHelper
    {
        private List<Animal> myFarm = new List<Animal>();

        public void addFarmMembers(Animal animal)
        {
            myFarm.Add(animal);
        }

        public void timePass(int daysPass)
        {
            for (int i = 0; i < myFarm.Count; i++)
            {
                if (myFarm[i].gettingOlder(daysPass) <= 0)
                {
                    myFarm.RemoveAt(i);
                    i--;
                }
            }
            checkFarmLifetimeStatus();
        }

        public void checkAnimalsAlive()
        {
            Console.WriteLine($"Farm members:");
            foreach (Animal animal in myFarm)
            {
                Console.WriteLine(animal.getName() +" age: "+ animal.getAge());
            }
            Console.WriteLine(Environment.NewLine);
        }

        public void checkFarmLifetimeStatus()
        {
            if (myFarm.Count == 0)
            {
                Console.WriteLine("The Farm is empty");
                Environment.Exit(1);
            }
        }

        public void selectAnimalsByAge(int minTargetAge, int maxTargetAge)
        {
            Console.WriteLine($"Farm members who are older than {minTargetAge} but younger than {maxTargetAge}:");
            for (int i = 0; i < myFarm.Count; i++)
            {
                if (myFarm[i].getAge() > minTargetAge && myFarm[i].getAge() <= maxTargetAge)
                {                    
                    Console.WriteLine(myFarm[i].getName());
                }            
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
