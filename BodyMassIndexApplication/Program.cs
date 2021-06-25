using System;

namespace BodyMassIndexApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadInputData inputdata = new ReadInputData();
            double height = inputdata.InputHeight();
            double weight = inputdata.InputWeight();

            BmiCalculator bmi = new BmiCalculator(height, weight);
            double result = bmi.BmiCalculation();

            ResultDisplay bmiresult = new ResultDisplay(result);
            bmiresult.Display();

        }
    }
}
