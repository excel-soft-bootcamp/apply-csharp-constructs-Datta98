using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BMIUserInputLib.UserInputs userInputs = new BMIUserInputLib.UserInputs();


            BMIValueCalculationLib.BmiValueCalculation value = new BMIValueCalculationLib.BmiValueCalculation();
            double BmiValue = value.calculator(userInputs.UserHeight(), userInputs.UserWeight());

            BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
            string message = validate.CheckCondition(BmiValue);

            BMIResultDisplayLib.MessageDisplay result = new BMIResultDisplayLib.MessageDisplay();
            result.Display(message);
            Console.ReadKey();

        }
    }
}
