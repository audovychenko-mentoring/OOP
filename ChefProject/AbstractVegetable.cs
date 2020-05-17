using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject.Vegetables
{
    class AbstractVegetable : Vegetable
    {
        public double caloriesPerOneGram;
        public int weigth;
        public double GetCaloricity()
        {
            return caloriesPerOneGram;
        }

        public double SetCalories(int weigth)
        {
            return GetCaloricity() * weigth;
        }

        public int GetWeith()
        {
            return weigth;
        }
    }
}
