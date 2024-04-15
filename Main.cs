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
            
            recipe.setRecipe();
            Console.WriteLine(recipe.viewRecipe());

            recipe.scaleIngredients();
            Console.WriteLine(recipe.viewRecipe());

            recipe.setOriginal();
            Console.WriteLine(recipe.viewRecipe());

            recipe.clearData();
            Console.WriteLine(recipe.viewRecipe());

        }           

    }




}
