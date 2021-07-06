using System;

namespace BMIUserInputLib
{
    public class ConsoleInputReader
    {
        public int GetUserHeight()
        {
             double height = Convert.ToDouble(this.ReadFromConsole("Enter your height in meter:"));
            return height;
        }

        public int GetUserWeight()
        {
             double weight = Convert.ToDouble(this.ReadFromConsole("Enter your weight in kg:"));
            return weight;
    }   
         private string ReadFromConsole(string message)
        {

            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
}
