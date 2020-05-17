
using MentoringTasks.FarmProject.FarmMembers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks
{
    class AnimalsFarm
    {
        public List<Animal> myFarm = new List<Animal>();

        public AnimalsFarm (List<Animal> animal)
        {
            myFarm.AddRange(animal);
        }

        public AnimalsFarm() {   }

        public void addFarmMembers(Animal animal)
        {
            myFarm.Add(animal);
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

        public void farmDeadAnimalsCollector()
        {
            for (int i = 0; i < myFarm.Count; i++)
            {
                if (myFarm[i].getAge() >= myFarm[i].getLifeLength())
                {
                    Console.WriteLine("!!! " + myFarm[i].getName() + " is dead, sorry");
                    myFarm.RemoveAt(i);               
                    i--;
                }
            }
        }

        public bool isFarmEmpty()
        {
            return (myFarm.Count == 0);          
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
