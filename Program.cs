using System;
namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max water capacity: ");
            double vMax = double.Parse(Console.ReadLine());
            Console.Write("Enter average water volume: ");
            double vFill = double.Parse(Console.ReadLine());
            Console.Write("Enter number of drinking water: ");
            double vDrink = double.Parse(Console.ReadLine());

            Console.Write("Enter event time: ");
            double tDay = double.Parse(Console.ReadLine());
            Console.Write("Enter round of filling water: ");
            double tFill = double.Parse(Console.ReadLine());
            Console.Write("Enter round of drink: ");
            double tDrink = double.Parse(Console.ReadLine());

            double totalWaterConsumed = vFill * (tDay / (double)(tDrink + tFill));
            double remainingWater = vMax - totalWaterConsumed;

            if (remainingWater >= 0)
            {
                Console.WriteLine("Enough Water, {0} left", remainingWater);
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }

            double refillCount = Math.Floor(tDay / (double)tFill);
            double overflowVolume = (refillCount * vFill) - vMax;

            if (overflowVolume > 0)
            {
                Console.WriteLine("Overflow Water");
            }
        }
    }
}