using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            BMIUserInputLib.ConsoleInputReader userInputs = new BMIUserInputLib.ConsoleInputReader();


            BMIValueCalculationLib.BmiValueCalculation value = new BMIValueCalculationLib.BmiValueCalculation();
            double BmiValue = value.BmiCalculation(userInputs.UserHeight(), userInputs.UserWeight());

            BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
            string message = validate.CheckBmiValue(BmiValue);

            BMIResultDisplayLib.MessageDisplay result = new BMIResultDisplayLib.MessageDisplay();
            result.ConsoleDisplay(message);
            Console.ReadKey();

        }
    }
}
