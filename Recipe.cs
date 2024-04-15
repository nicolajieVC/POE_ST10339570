using System;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;

namespace POE1
{
    class Recipe
    {

        string nameRecipe; // name of the recipe
        int numIngredients; // number of ingredients
        int numSteps; // number of steps

        Ingredients[] ingredients; //creating arrays
        Steps[] steps;

        public string viewRecipe() //method to display the ingredients and steps
        {
            string ingredientsOut = "\n\nName of the recipe: " + nameRecipe + "\n\nIngredients:\n";
            for (int i = 0; i < numIngredients; i++)
            {
                ingredientsOut += (i+1) + ") " + ingredients[i].getName() + " " +  ingredients[i].getQuantity() + " " + ingredients[i].getUnitOfMeasure() + ("\n");
            }

            string stepsOut = "\n\nSteps to follow: \n\n";

            for(int i = 0;i < numSteps; i++)
            {
                stepsOut += (i + 1) + ") " + steps[i].getStepDesc() + "\n";
            }
            return ingredientsOut + stepsOut;

        }

        public void setRecipe() // method in populating the ingredient and steps arrays
        {

            Console.WriteLine("Please enter the name of the Recipe you would like to create:");
            nameRecipe = Console.ReadLine();

            Console.WriteLine("Please enter the number of ingredients in the recipe:");
            numIngredients = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the number of steps in the recipe:");
            numSteps = int.Parse(Console.ReadLine());

            ingredients = new Ingredients[numIngredients];
            steps = new Steps[numSteps];

            //Getting Ingredients.

            for (int i = 0;i < numIngredients ; i++)
            {
                String name;
                String measurement;
                double quantity;

                Console.WriteLine("Please enter the name of ingredient " + (i+1));
                name = Console.ReadLine();

                Console.WriteLine("Please enter the quantity of ingredient " + (i + 1));
                quantity = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the unit of measurment for ingredient " + (i + 1));
                measurement = Console.ReadLine();

                ingredients[i] = new Ingredients(name, quantity, measurement);

            }

            //Getting Steps

            for (int i = 0; i < numSteps; i++)
            {
                String description;

                Console.WriteLine("Please enter the method for step " + (i + 1));
                description = Console.ReadLine();

                steps[i] = new Steps(description);

            }


        }

        public void clearData() // method to clear all data
        {
            Console.WriteLine("Would you like to clear the data/recipe? (y = yes n = no)");
            char[] temp = Console.ReadLine().ToCharArray();
            if (temp[0] == 'y' || temp[0] == 'Y')
            {
                for (int i = 0; i < numIngredients; i++)
                {
                    ingredients[i] = new Ingredients("",0,"");
                }
                for (int i = 0; i < numSteps; i++)
                {
                    steps[i] = new Steps("");
                }
                nameRecipe = "";
            }

        }

        public void setOriginal() // method to set the data back to the original data inputted
        {
            Console.WriteLine("Would you like to reset the quantities? (y = yes n = no)");
            char[] temp = Console.ReadLine().ToCharArray();


            if (temp[0] == 'y' || temp[0] == 'Y')
            {
                for (int i = 0; i < numIngredients; i++)
                {
                    ingredients[i].setOriginalQuantity();
                }
            }

            
        }

        public void scaleIngredients() // method to scale quantities
        {
            Console.WriteLine("Would you like to scale the quantities? (y = yes n = no)");
            char[] temp = Console.ReadLine().ToCharArray();


            if (temp[0] == 'y' || temp[0] == 'Y')
            {
                Console.WriteLine("How much would you like to scale the quantities by? (e.g 0.5 , 1 , 2 , 3)");
                double scale = double.Parse(Console.ReadLine());
                for (int i = 0;i < numIngredients; i++)
                {
                    ingredients[i].scaleQuantities(scale);
                }
            }
        }


    }
}
    