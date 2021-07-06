using System;

namespace BMIValueCalculationLib
{
    public class CalculateBMI
    {

        public double BmiCalculation(double height, double weight)
        {
            double bmivalue = weight / height;
            return bmivalue;
        }

    }
}
