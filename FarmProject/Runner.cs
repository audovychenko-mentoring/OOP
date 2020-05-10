using MentoringTasks.FarmProject.FarmMembers;
using System;

namespace MentoringTasks
{
    class Runner
    {
        static void Main(string[] args)
        {
            AnimalsFarmHelper myFarm = new AnimalsFarmHelper();
            Cow milla = new Cow("Milla");
            Chicken cindy = new Chicken("Cindy");            
            myFarm.addFarmMembers(milla);
            myFarm.addFarmMembers(cindy);
            milla.makeNoise();
            myFarm.timePass(120);
            myFarm.checkAnimalsAlive();
            Chicken melissa = new Chicken("Melisa");
            myFarm.addFarmMembers(melissa);
            myFarm.selectAnimalsByAge(0, 200);
            myFarm.checkAnimalsAlive();
            myFarm.timePass(400);
            myFarm.checkAnimalsAlive();
        }
    }
}
