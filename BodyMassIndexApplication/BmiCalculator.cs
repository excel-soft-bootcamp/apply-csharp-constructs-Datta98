using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexApplication
{
    class BmiCalculator
    {

        private double height;
        private double weight;
        private double result;

       
        public double  BmiCalculation( double height, double weight)
        {
            this.height = height;
            this.weight = weight;

            this.result = this.weight / this.height;
            return this.result;

                
        }
       
    }
}
