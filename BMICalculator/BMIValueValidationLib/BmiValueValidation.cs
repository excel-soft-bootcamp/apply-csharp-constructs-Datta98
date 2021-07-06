using System;

namespace BMIValueValidationLib
{
    public class BmiValueValidation
    {
        public string CheckCondition(double BMIValue)
        {
            if (BMIValue < 18.5)
            {
                return "UnderWeight";
            }
            else if (BMIValue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }

    }
}
