using System;

namespace Bodymassindex
{
    class Program
    {
       
        static void Main(string[] args)
        {

            
            Program obj1 = new Program();
            obj1.Reader();
            Program obj2 = new Program();
            obj2.calculator();

         }

        public void Reader ()
        {
            int weight, height;
            Console.WriteLine("Enter the weight in kg's : ");
            weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height in meters : ");
            height = Convert.ToInt32(Console.ReadLine());

        }
        
        public void calculator()
        {
            Reader();
            int  BMI;

            BMI = weight / height;

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


            Console.WriteLine("Results");
            Console.WriteLine("BodyMassIndex " + BMI);
           

        }
    }

   
}