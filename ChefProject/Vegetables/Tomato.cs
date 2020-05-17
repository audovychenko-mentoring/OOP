using MentoringTasks.ChefProject.Vegetables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Tomato: AbstractVegetable
    {
        public Tomato(int weigth)
        {
            this.weigth = weigth;
            caloriesPerOneGram = 0.18;
            string name = "Tomato";
        }
    }
}
