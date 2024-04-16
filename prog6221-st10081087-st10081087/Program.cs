using System;

namespace prog6221_st10081087_st10081087
{
    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
    }

    class Step
    {
        public string Description { get; set; }
    }

    class Recipe
    {
        public string Name { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public Step[] Steps { get; set; }

        public Recipe(string name, Ingredient[] ingredients, Step[] steps)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }
            Console.WriteLine("Steps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {

            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new Ingredient[]
            {
                new Ingredient { Name = "Sugar", Quantity = 1, Unit = "tablespoon" },
            };

            var steps = new Step[]
            {
                new Step { Description = "Step 1: Mix sugar with water" },
            };

            var recipe = new Recipe("Example Recipe", ingredients, steps);

            recipe.DisplayRecipe();

            recipe.ScaleRecipe(2);
            Console.WriteLine("\nRecipe after scaling:");
            recipe.DisplayRecipe();

            recipe.ResetQuantities();
            Console.WriteLine("\nRecipe after resetting quantities:");
            recipe.DisplayRecipe();
        }
    }
   // References:
// https://youtu.be/aripIuUPO-Q?si=nWZsEDPM9Qlg6gq2
//https://stackoverflow.com/questions/tagged/c%23
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
//https://www.w3schools.com/cs/cs_classes.php
 
}






