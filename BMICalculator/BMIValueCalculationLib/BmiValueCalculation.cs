using System;

namespace BMIValueCalculationLib
{
    public class BmiValueCalculation
    {

        private double bmivalue;

        public double BmiCalculation(double height, double weight)
        {
            bmivalue = weight / height;
            return bmivalue;
        }

    }
}
