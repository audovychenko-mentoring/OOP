
using MentoringTasks.FarmProject.FarmMembers;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks
{
    class AnimalsFarmHelper
    {
        public List<Animal> myFarm = new List<Animal>();

        public void addFarmMembers(Animal animal)
        {
            myFarm.Add(animal);
        }

        internal void doDailyRoutine()
        {
            throw new NotImplementedException();
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

        public void fillFarmWithAnimals()
        {
            AnimalsFarmHelper myFarm = new AnimalsFarmHelper();
            Cow milla = new Cow("Milla");
            Chicken cindy = new Chicken("Cindy");
            myFarm.addFarmMembers(new Cow("Milla"));
            myFarm.addFarmMembers(cindy);
            Chicken melissa = new Chicken("Melisa");
            myFarm.addFarmMembers(melissa);
        }
    }
}
