using System;
using System.Collections.Generic;
using System.Text;

namespace BodyMassIndexApplication
{
    class ReadInputData
    {
        public double InputHeight()
        {
            System.Console.WriteLine("Enter your height in meters");
            double Height = Convert.ToDouble((Console.ReadLine());
            return Height;
        }
        public double InputWeight()
        {
            System.Console.WriteLine("Enter your Weight in Kg's ");
            double Weight = Convert.ToDouble((Console.ReadLine());
            return Weight;
        }

    }
}
