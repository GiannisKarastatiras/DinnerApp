using DinnerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DinnerApp.HelperClasses
{
    public class EntreeManager
    {
        public static List<Entree> GetAll()
        {
            List<Entree> entrees = new List<Entree>();
            entrees.Add(new Entree()
            {
                ID = 1,
                Name = "Sopa",
                Ingredients = new List<Ingredient>()
                { 
                    new Ingredient(){Name = "Pasta", Amount = 3, Unit = "Cups"},
                    new Ingredient(){Name = "Tomato Sauce", Amount = 2, Unit = "Cups"},
                    new Ingredient(){Name = "Ground Beef", Amount = 1, Unit = "Pound"}
                }
            });

            entrees.Add(new Entree()
            {
                ID = 2,
                Name = "Lazy Enchiladas",
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient(){Name = "Corn Tortillas", Amount = 18, Unit = "Items"},
                    new Ingredient(){Name = "Enchiladas Sauce", Amount = 2.5M, Unit = "Cups"},
                    new Ingredient(){Name = "Mexican Cheese", Amount = 0.75M, Unit = "Cups"},
                    new Ingredient(){Name = "Green Chillis", Amount = 1, Unit = "Can"}
                }
            });
            return entrees;


        }
    }
}