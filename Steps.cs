using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE1
{
    internal class Steps
    {
        string stepDesc; // the description of each step will be stored here

        public Steps( string stepDesc) 
        {
           
            this.stepDesc = stepDesc;
        }

        public string getStepDesc() // get method for the description of the step
        {  
            return stepDesc; }

    }
}
