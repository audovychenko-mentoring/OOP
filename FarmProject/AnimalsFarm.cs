
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks
{
    class AnimalsFarm
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
                }
                else continue;
            }
        }

        public void checkStatus()
        {
            foreach (Animal animal in myFarm)
            {
                Console.WriteLine(animal.getName());
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
