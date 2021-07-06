using System;

namespace BMIValueCalculationLib
{
    public class BmiValueCalculation
    {

        private double bmivalue;

        public double calculator(double height, double weight)
        {
            bmivalue = weight / height;
            return bmivalue;
        }

    }
}
