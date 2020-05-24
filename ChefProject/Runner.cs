using MentoringTasks.ChefProject.Vegetables;
using MentoringTasks.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Runner
    {
        public static void Main(string[] args)
        {
            DictionaryCollection dictionaryCollection = new DictionaryCollection();
            dictionaryCollection.FillCollection();
            dictionaryCollection.FindAndPrintValueByKey(6);
            dictionaryCollection.RemoveElementByKey(100);
            ListCollection listCollection = new ListCollection();            
            listCollection.FillCollection();
            listCollection.FindAndPrintValueByPosition(600);
            listCollection.RemoveElementByPosition(250);
            QueueCollection queueCollection = new QueueCollection();
            queueCollection.FillCollection();
            queueCollection.FindAndPrintFirstElement();
            queueCollection.RemoveBeginningElement();
            SortedListCollection sortedListCollection = new SortedListCollection();
            sortedListCollection.FillCollection();
            sortedListCollection.FindAndPrintValueByKey(300);
            sortedListCollection.RemoveElementByKey(1000);
            StackCollection stackCollection = new StackCollection();
            stackCollection.FillCollection();
            stackCollection.FindAndPrintTopElement();
            stackCollection.RemoveTopElement();
            /*List<Vegetable> springSaladIngredients = new List<Vegetable>() 
            { 
                new Tomato(200), 
                new Cucumber(200), 
                new Onion(50) 
            };
            Salad springSalad = new Salad (springSaladIngredients, "Spring Salad");
            List<Vegetable> tangySaladIngredients = new List<Vegetable>() 
            { 
                new Cucumber(200), 
                new Avocado(200), 
                new Lime(50), 
                new GreenOnion(50) 
            };
            Salad tangySalad = new Salad(tangySaladIngredients, "Tangy Salad");
            springSalad.getSaladCaloricity();
            tangySalad.getSaladCaloricity();
            springSalad.sortByCalories();
            springSalad.sortByWeigth();
            tangySalad.selectVegetablesByWeigth(40, 150) ; */
        }
    }
}
