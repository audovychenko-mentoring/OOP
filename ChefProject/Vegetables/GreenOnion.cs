using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject.Vegetables
{
    class GreenOnion: AbstractVegetable
    {
        public GreenOnion(int weigth)
        {
            this.weigth = weigth;
            caloriesPerOneGram = 0.32;
            name = "GreenOnion";
        }
    }
}
