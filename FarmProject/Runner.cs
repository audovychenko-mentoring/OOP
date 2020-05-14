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
            while (myBrandNewFarm.isFarmEmpty())
            {
            int daysPass = 1;            
                foreach (Animal animal in myBrandNewFarm.myFarm) 
                {
                    animal.makeNoise();
                    animal.eat();
                    animal.sleep();
                    animal.gettingOlder(daysPass);
                }
            daysPass++;
            }
        }
    }
}
