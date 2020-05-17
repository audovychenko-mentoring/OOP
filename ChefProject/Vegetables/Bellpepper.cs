using MentoringTasks.ChefProject.Vegetables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Bellpepper: AbstractVegetable
    {
        public Bellpepper(int weigth)
        {
            this.weigth = weigth;
            caloriesPerOneGram = 0.26;
            string name = "Bellpepper";
        }
    }
}
