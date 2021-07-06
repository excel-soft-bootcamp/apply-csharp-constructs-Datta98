using System;

namespace BMIUserInputLib
{
    public class ConsoleInputReader
    {
        public double GetUserHeight()
        {
             ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your height in meter");
            string heightInMeter = Console.ReadLine();
            double height = double.Parse(heightInMeter);
            return height;
        }

        public double GetUserWeight()
        {
             ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your weight in KG");
            string weightInKG = Console.ReadLine();
            double weight = double.Parse(weightInKG);
            return weight; ;
    }   
        
}
