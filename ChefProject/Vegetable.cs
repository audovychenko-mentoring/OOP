using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    interface Vegetable
    {
        public int Weigth { get; }

        public double Caloricity { get; set; }

        public double SetCalories(int weigth);

        public string Name { get; }
    }
}
