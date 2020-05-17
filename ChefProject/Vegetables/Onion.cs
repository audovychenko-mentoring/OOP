using MentoringTasks.ChefProject.Vegetables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Onion: AbstractVegetable
    {
        public Onion(int weigth)
        {
            this.weigth = weigth;
            caloriesPerOneGram = 0.42;
            string name = "Onion";
        }
    }
}
