using MentoringTasks.Farm.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MentoringTasks.FarmProject.FarmMembers
{
    class Cow: AbstractAnimal, Cattle
    {
        public int producedMilk = 0;

        public Cow(string name)
        {
            this.name = name;
            lifeLength = 25;
            sound = "Mooo";
            food = new String[3] { "grass", "corn", "grain" };
            age = 0;
        }

        public override int givingProduce(int daysPass)
        {
            producedMilk += daysPass * 5;
            return daysPass * 5;
        }
    }
}
