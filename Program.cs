using System;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEight = new Building("512 8th Avenue")
            {
                Width = 3000,
                Stories = 10,
                Depth = 3000,
            };

            Building ThreeZeroOne = new Building("301 Plus Park Blv")
            {
                Width = 5000,
                Stories = 15,
                Depth = 5000,
            };

            FiveOneTwoEight.Construct();
            FiveOneTwoEight.Purchase("Mac");

            ThreeZeroOne.Construct();
            ThreeZeroOne.Purchase("Steve Brownlee");

            Console.WriteLine(FiveOneTwoEight.Description);
            Console.WriteLine(ThreeZeroOne.Description);
        }
    }
}