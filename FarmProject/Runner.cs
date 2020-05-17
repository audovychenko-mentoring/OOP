using MentoringTasks.FarmProject.FarmMembers;
using System;
using System.Security.Cryptography;
using System.Linq;

namespace MentoringTasks
{
    class Runner
    {
        static void TestMain(string[] args)
        {
            AnimalsFarm myBrandNewFarm = new AnimalsFarm();
            myBrandNewFarm.addFarmMembers(new Cow("Milla"));
            myBrandNewFarm.addFarmMembers(new Chicken("Cindy"));
            myBrandNewFarm.addFarmMembers(new Chicken("Melisa"));
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
                    animal.givingProduce(1);
                }
                myBrandNewFarm.farmDeadAnimalsCollector();
                daysCount++;
            }
            Console.WriteLine("Farm stoped functioning. There are no animals");
        }
    }
}
