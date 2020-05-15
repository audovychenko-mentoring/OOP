using MentoringTasks.FarmProject.FarmMembers;
using System;
using System.Security.Cryptography;
using System.Linq;

namespace MentoringTasks
{
    class Runner
    {
        static void Main(string[] args)
        {
            AnimalsFarmHelper myBrandNewFarm = new AnimalsFarmHelper();
            myBrandNewFarm.fillFarmWithAnimals();
            int daysCount = 1;
            while (!myBrandNewFarm.isFarmEmpty())
            {
                Console.WriteLine("Day " + daysCount);
                foreach (Animal animal in myBrandNewFarm.myFarm) 
                {
                    animal.makeNoise();
                    animal.eat();
                    animal.sleep();
                    animal.gettingOlder(1);
                }
                myBrandNewFarm.farmDeadAnimalsCollector();
                daysCount++;
            }
            Console.WriteLine("Farm stoped functioning. There are no animals");
        }
    }
}
