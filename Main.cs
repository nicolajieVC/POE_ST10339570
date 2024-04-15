using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE1
{
   class MainClass
    {
        public static void Main(string[] args)
        {

            Recipe recipe = new Recipe(); 
            
            recipe.setRecipe(); //setting the recipe
            Console.WriteLine(recipe.viewRecipe()); // displaying the recipe 

            recipe.scaleIngredients(); // scaling the recipe
            Console.WriteLine(recipe.viewRecipe()); // displaying the recipe 

            recipe.setOriginal(); // setting the recipe to the original
            Console.WriteLine(recipe.viewRecipe()); // displaying the recipe 

            recipe.clearData();// clearing the recipe
            Console.WriteLine(recipe.viewRecipe()); // displaying the recipe 

        }           

    }




}
