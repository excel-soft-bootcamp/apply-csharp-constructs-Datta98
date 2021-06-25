using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexApplication
{
    class ResultDisplay
    {
        private double result;

        public double Display(double result)
        {
            this.result = result;

            if (this.result < 18.5)
                Console.WriteLine("You are Underweight");

            else if (this.result >= 25)
            { 
                Console.WriteLine("You areUnderweight");
            }
            else
            {
                Console.WriteLine("You are Healthy");
            }
             
        }

        


    }
}
