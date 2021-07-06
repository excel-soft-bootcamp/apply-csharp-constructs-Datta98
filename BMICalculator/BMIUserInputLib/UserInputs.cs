using System;

namespace BMIUserInputLib
{
    public class ConsoleInputReader
    {
        public double GetUserHeight()
        {
             ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your height in meter:");
            string heightInMeter = Console.ReadLine();
            int height = int.Parse(heightInMeter);
            return height;
        }

        public double GetUserWeight()
        {
             ConsoleDisplayLib.ConsoleDisplayType.ConsoleDisplay("Enter your weight in KG:");
            string weightInKG = Console.ReadLine();
            int weight = int.Parse(weightInKG);
            return weight; ;
    }   
        
}
