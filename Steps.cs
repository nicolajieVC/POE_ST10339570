using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE1
{
    internal class Steps
    {
        string stepDesc;

        public Steps( string stepDesc)
        {
           
            this.stepDesc = stepDesc;
        }

        public string getStepDesc() 
        {  
            return stepDesc; }

    }
}
