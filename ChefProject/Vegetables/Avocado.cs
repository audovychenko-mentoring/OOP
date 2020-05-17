using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject.Vegetables
{
    class Avocado: AbstractVegetable
    {
        public Avocado(int weigth)
        {
            this.weigth = weigth;
            caloriesPerOneGram = 1.6;
            name = "Acocado";
        }
    }
}
