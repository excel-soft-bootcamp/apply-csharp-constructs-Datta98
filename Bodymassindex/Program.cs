using System;

namespace Bodymassindex
{
    class Program
    {
        static void Main(string[] args)
        {

            int weight, height, BMI = 0;
            Console.WriteLine("Enter the weight in kg's : ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height in meters : ");
            height = Convert.ToInt32(Console.ReadLine());

            BMI = weight / height;

            Console.WriteLine("Results");
            Console.WriteLine("BodyMassIndex {0}", BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (BMI >= 25)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Healthy");
            }




        }
    }

   
}