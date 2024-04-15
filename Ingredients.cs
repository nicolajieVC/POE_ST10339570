using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE1
{
    internal class Ingredients
    { 
        string name;
        double quantity;
        string unitOfMeasure;
        double quantityOriginal;

        public Ingredients(string name, double quantity, string unitOfMeasure)
        {
            this.name = name;
            this.quantity = quantity;
            this.quantityOriginal = quantity;
            this.unitOfMeasure = unitOfMeasure;
        }
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

        public void scaleQuantities(double scale)
        {
            double output = quantity * scale;
            quantity = output;

        }
        public void setOriginalQuantity()
        {
            quantity = quantityOriginal;
        }


    }
}
