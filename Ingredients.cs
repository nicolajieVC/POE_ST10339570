using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE1
{
    internal class Ingredients
    { 
        string name; // name of the ingredient
        double quantity; // quantity of that ingredient
        string unitOfMeasure; // unit of measurement for tha ingredient
        double quantityOriginal; // original stored quantities for the ingredient

        public Ingredients(string name, double quantity, string unitOfMeasure) //ingredients object
        {
            this.name = name;
            this.quantity = quantity;
            this.quantityOriginal = quantity;
            this.unitOfMeasure = unitOfMeasure;
        }

        // methods to get information from ingredients
        public string getName()
        {
            return name; 
        }
        public double getQuantity()
        {
            return quantity;
        }
        public string getUnitOfMeasure()
        {
            return unitOfMeasure;
        }

        public void scaleQuantities(double scale)// method to scale the quantities
        {
            double output = quantity * scale;
            quantity = output;

        }
        public void setOriginalQuantity() // method to set original quantities
        {
            quantity = quantityOriginal;
        }


    }
}
