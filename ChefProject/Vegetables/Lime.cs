using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject.Vegetables
{
    class Lime: AbstractVegetable
    {
        public Lime(int weigth) 
        {
            this.weigth = weigth;
            caloriesPerOneGram = 0.3;
            string name = "Lime";
        }
    }
}
