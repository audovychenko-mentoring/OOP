using MentoringTasks.ChefProject.Vegetables;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Runner
    {
        public static void Main(string[] args)
        {
            List<Vegetable> springSaladIngredients = new List<Vegetable>() { new Tomato(200), new Cucumber(200), new Onion(50) };
            Salad springSalad = new Salad (springSaladIngredients, "Spring Salad");
            List<Vegetable> tangySaladIngredients = new List<Vegetable>() { new Cucumber(200), new Avocado(200), new Lime(50), new GreenOnion(50) };
            Salad tangySalad = new Salad(tangySaladIngredients, "Tangy Salad");
            springSalad.getSaladCaloricity();
            tangySalad.getSaladCaloricity();
        }
    }
}
