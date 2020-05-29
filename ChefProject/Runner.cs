using MentoringTasks.ChefProject.Vegetables;
using MentoringTasks.Collections;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace MentoringTasks.ChefProject
{
    class Runner
    {
        public static void Main(string[] args)
        {
            DictionaryCollection dictionaryCollection = new DictionaryCollection();
            ListCollection listCollection = new ListCollection();
            QueueCollection queueCollection = new QueueCollection();
            SortedListCollection sortedListCollection = new SortedListCollection();
            StackCollection stackCollection = new StackCollection();

            dictionaryCollection.FillCollection("dictionary");
            listCollection.FillCollection();
            queueCollection.FillCollection();
            sortedListCollection.FillCollection("sorted list");
            stackCollection.FillCollection();
            Console.WriteLine();

            dictionaryCollection.FindValueByKey(6, "dictionary");
            listCollection.FindValueByPosition(600);
            queueCollection.FindFirstElement();
            sortedListCollection.FindValueByKey(300, "sorted list");
            stackCollection.FindTopElement();
            Console.WriteLine();

            dictionaryCollection.RemoveElementByKey(100, "dictionary");                       
            listCollection.RemoveElementByPosition(250);        
            queueCollection.RemoveBeginningElement();
            sortedListCollection.RemoveElementByKey(1000, "sorted list");
            stackCollection.RemoveTopElement();
            Console.WriteLine();

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
