using System;
using System.IO;

namespace BMICalculatorApplication
{
    public enum options
    {
        ConsoleInput = 1,FileInput
    }

    class Program
    {
        static void Main(string[] args)
        {

            string displaymessage = $"Enter Your Choice \n {(int)options.ConsoleInput}->console Input \n {(int)options.FileInput }->File Input";
            Console.WriteLine(displaymessage);
            options choice = (options)Int32.Parse(Console.ReadLine());

            switch(choice)
            {
                case options.ConsoleInput:

                    BMIUserInputLib.UserInputs userInputs = new BMIUserInputLib.UserInputs();


                    BMIValueCalculationLib.BmiValueCalculation value = new BMIValueCalculationLib.BmiValueCalculation();
                    double BmiValue = value.calculator(userInputs.GetUserHeight(), userInputs.GetUserWeight());

                    BMIValueValidationLib.BmiValueValidation validate = new BMIValueValidationLib.BmiValueValidation();
                    string message = validate.CheckBmiValue(BmiValue);

                    BMIResultDisplayLib.MessageDisplay result = new BMIResultDisplayLib.MessageDisplay();
                    result.Display(message);
                    Console.ReadKey();
                    break;



                case options.FileInput:

                    string filepath = @"C:\Users\shridatta.r\Documents\Datta\PatientDeatails.txt";

                    string[] lines = File.ReadAllLines(filepath);
                    string[] details = lines[2].Split(",");
                    foreach (string line in lines)
                    {
                        
                        Console.WriteLine( details);
                    }

                    

                    Console.ReadLine( );


                    
                    break;





            }


           








        }
    }
}
