using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Salad
    {
        List<Vegetable> MySalad = new List<Vegetable>();
        private double mySaladCaloricity;
        private string name;

        public Salad(List<Vegetable> vegetable, string name) 
        {
            this.name = name;
            MySalad.AddRange(vegetable);
            mySaladCaloricity = 0;
            foreach (Vegetable justAddedVegetable in vegetable)
            {
                mySaladCaloricity = mySaladCaloricity + justAddedVegetable.SetCalories(justAddedVegetable.GetWeith());
            }
        }

        //public Salad() { }

        public void getSaladCaloricity()
        {
            Console.WriteLine($"There are {mySaladCaloricity} calories in {getName()}");
        }

        public string getName()
        {
            return name;
        }
    }
}
