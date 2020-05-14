using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.FarmProject.FarmMembers
{
    class Pig: AbstractAnimal
    {
        public int producedMeat = 0;

        public Pig(String name)
        {
            this.name = name;
            lifeLength = 150;
            sound = "";
            food = new String[3] { "mash", "crumble", "pellets" };
            age = 0;
    }

        public override int givingProduce(int daysPass)
        {
            producedMeat += daysPass * 2;
            return daysPass * 2;
        }
    }
}
