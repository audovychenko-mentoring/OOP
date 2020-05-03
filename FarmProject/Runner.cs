using MentoringTasks.Farm;
using MentoringTasks.Farm.FarmMembers;
using System;

namespace MentoringTasks
{
    class Runner
    {
        static void Main(string[] args)
        {
            AnimalsFarm myFarm = new AnimalsFarm();
            Cow milla = new Cow("Milla");
            Chicken cindy = new Chicken("Cindy");            
            myFarm.addFarmMembers(milla);
            myFarm.addFarmMembers(cindy);
            milla.makeNoise();
            myFarm.timePass(120);
            myFarm.checkStatus();
            Chicken melissa = new Chicken("Melisa");
            myFarm.addFarmMembers(melissa);
            myFarm.checkStatus();
            myFarm.timePass(120);
            myFarm.checkStatus();
        }
    }
}
