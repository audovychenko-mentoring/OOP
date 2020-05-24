using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MentoringTasks.ChefProject.Vegetables
{
    abstract class AbstractVegetable : Vegetable
    {
        public double caloriesPerOneGram;
        public int weigth;
        public string name;

        public int Weigth { get => weigth; }
        public double Caloricity { get => caloriesPerOneGram; set => SetCalories(weigth); }

        public double SetCalories(int weigth)
        {
            return Caloricity * weigth;
        }

        public string Name { get => name; }
    }
}
