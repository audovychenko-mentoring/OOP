using MentoringTasks.FarmProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.FarmProject.FarmMembers
{
    class Chicken: AbstractAnimal, Bird
    {
        public int producedEggs = 0;

        public Chicken(String name)
        {
             this.name = name;
             lifeLength = 15;
             sound = "Co Co Co";
             food = new String[3] { "mash", "crumble", "pellets" };
             age = 0;             
        }

        public override int givingProduce(int daysPass)
        {
            producedEggs += daysPass * 3;
            return daysPass * 5;
        }

        public void fly()
        {
            Console.WriteLine("Trying to escape");
        }
    }
}
