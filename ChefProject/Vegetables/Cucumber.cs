using MentoringTasks.ChefProject.Vegetables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Cucumber: AbstractVegetable
    {
        public Cucumber(int weigth)
        {
            this.weigth = weigth;
            caloriesPerOneGram = 0.15;
            string name = "Cucumber";
        }
    }
}
