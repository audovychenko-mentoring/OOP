using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Salad
    {
        private List<Vegetable> mySalad = new List<Vegetable>();
        private double mySaladCaloricity;
        private string name;

        public Salad(List<Vegetable> vegetables, string name)
        {
            this.name = name;
            mySalad.AddRange(vegetables);
            mySaladCaloricity = 0;
            foreach (Vegetable justAddedVegetable in vegetables)
            {
                mySaladCaloricity = mySaladCaloricity + justAddedVegetable.SetCalories(justAddedVegetable.Weigth);
            }
        }

        public Salad() { }

        public void getSaladCaloricity()
        {
            Console.WriteLine($"There are {mySaladCaloricity} calories in {getName()}");
        }

        public void sortByCalories()
        {
            List<Vegetable> SortedVegetables = mySalad.OrderBy(o => o.Caloricity).ToList();
            Console.WriteLine(getName() + " salad ingredients sorted by calories:");
            foreach (Vegetable vegetable in SortedVegetables)
            {                
                Console.WriteLine(vegetable.Name + " has " + vegetable.Caloricity + " calories");
            }
        }

        public void sortByWeigth()
        {
            List<Vegetable> SortedVegetables = mySalad.OrderBy(o => o.Weigth).ToList();
            Console.WriteLine(getName() + " salad ingredients sorted by weigth:");
            foreach (Vegetable vegetable in SortedVegetables)
            {
                Console.WriteLine(vegetable.Name + " has " + vegetable.Weigth + " weigth");
            }
        }

        public void selectVegetablesByWeigth(int minTargetWeigth, int maxTargetWeigth)
        {
            Console.WriteLine($"{getName()} ingredients that heavier than {minTargetWeigth} but lighter than {maxTargetWeigth}:");
            for (int i = 0; i < mySalad.Count; i++)
            {
                if (mySalad[i].Weigth > minTargetWeigth && mySalad[i].Weigth <= maxTargetWeigth)
                {
                    Console.WriteLine(mySalad[i].Name);
                }
            }
            Console.WriteLine(Environment.NewLine);
        }

        public string getName()
        {
            return name;
        }
    }
}
