using System;

namespace BMIValueCalculationLib
{
    public class CalculateBMI
    {

        private double bmivalue;

        public double BmiCalculation(double height, double weight)
        {
            bmivalue = weight / height;
            return bmivalue;
        }

    }
}
