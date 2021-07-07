using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
                BMIUserInputLib.ConsoleInputReader userInputs = new BMIUserInputLib.ConsoleInputReader();


                BMIValueCalculationLib.CalculateBMI value = new BMIValueCalculationLib.CalculateBMI();
                double BmiValue = value.BmiCalculation(userInputs.GetUserHeight(), userInputs.GetUserWeight());

                BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
                string message = validate.CheckBmiValue(BmiValue);

                BMIResultDisplayLib.MessageDisplay result = new BMIResultDisplayLib.MessageDisplay();
                result.Display(message);
                Console.ReadKey();

            
        }
    }
}
